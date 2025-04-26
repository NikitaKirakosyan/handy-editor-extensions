using System;
using UnityEngine;
using UnityEditor;

namespace HandyEditorExtensions.Editor
{
    [CustomPropertyDrawer(typeof(MultiThresholdColorAttribute))]
    public class MultiThresholdColorAttributePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            // 1) Обычное поле, если не int/float
            if(property.propertyType != SerializedPropertyType.Integer &&
               property.propertyType != SerializedPropertyType.Float)
            {
                EditorGUI.PropertyField(position, property, label);
                return;
            }

            // 2) Синхронизируем SerializedObject
            property.serializedObject.Update();

            // 3) Берём атрибут и текущий value
            var attr = (MultiThresholdColorAttribute)attribute;
            float value = (property.propertyType == SerializedPropertyType.Integer)
                ? property.intValue
                : property.floatValue;

            // 4) Парсим hex-коды в Color[] (раз в каждом рендере — можно кешировать, если нужно)
            int n = attr.thresholds.Length;
            Color[] cols = new Color[n];
            for(int i = 0; i < n; i++)
            {
                if(!ColorUtility.TryParseHtmlString(attr.colorHexes[i], out cols[i]))
                    cols[i] = Color.white;
            }

            // 5) Собираем кортежи и сортируем по порогу
            var entries = new (float threshold, Color color)[n];
            for(int i = 0; i < n; i++)
                entries[i] = (attr.thresholds[i], cols[i]);
            Array.Sort(entries, (a, b) => a.threshold.CompareTo(b.threshold));

            // 6) Находим цвет последнего порога ≤ value
            Color chosen = GUI.backgroundColor;
            foreach(var e in entries)
            {
                if(value >= e.threshold) chosen = e.color;
                else break;
            }

            // 7) Разбиваем область на лейбл и поле
            float lw = EditorGUIUtility.labelWidth;
            var rLabel = new Rect(position.x, position.y, lw, position.height);
            var rField = new Rect(position.x + lw,
                position.y,
                position.width - lw,
                position.height);

            // 8) Рисуем в зависимости от режима
            if(attr.mode == ThresholdColorMode.Label)
            {
                var prev = GUI.contentColor;
                GUI.contentColor = chosen;
                EditorGUI.LabelField(rLabel, label);
                GUI.contentColor = prev;

                EditorGUI.PropertyField(rField, property, GUIContent.none);
            }
            else
            {
                EditorGUI.DrawRect(position, chosen);
                EditorGUI.LabelField(rLabel, label);
                EditorGUI.PropertyField(rField, property, GUIContent.none);
            }

            // 9) Применяем изменения
            property.serializedObject.ApplyModifiedProperties();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            // По высоте как обычное поле
            return EditorGUI.GetPropertyHeight(property, label);
        }
    }
}