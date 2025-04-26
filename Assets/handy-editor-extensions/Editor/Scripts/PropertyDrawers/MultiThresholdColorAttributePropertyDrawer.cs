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
            if(property.propertyType != SerializedPropertyType.Integer &&
               property.propertyType != SerializedPropertyType.Float)
            {
                EditorGUI.PropertyField(position, property, label);
                return;
            }

            property.serializedObject.Update();

            var attr = (MultiThresholdColorAttribute)attribute;
            var value = property.propertyType == SerializedPropertyType.Integer ? property.intValue : property.floatValue;

            var n = attr.thresholds.Length;
            var cols = new Color[n];
            for(var i = 0; i < n; i++)
            {
                if(!ColorUtility.TryParseHtmlString(attr.colorHexes[i], out cols[i]))
                    cols[i] = Color.white;
            }

            var entries = new (float threshold, Color color)[n];
            for(var i = 0; i < n; i++)
                entries[i] = (attr.thresholds[i], cols[i]);
            Array.Sort(entries, (a, b) => a.threshold.CompareTo(b.threshold));

            var chosen = GUI.backgroundColor;
            foreach(var e in entries)
            {
                if(value >= e.threshold)
                    chosen = e.color;
                else
                    break;
            }

            var lw = EditorGUIUtility.labelWidth;
            var rLabel = new Rect(position.x, position.y, lw, position.height);
            var rField = new Rect(position.x + lw, position.y, position.width - lw, position.height);

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

            property.serializedObject.ApplyModifiedProperties();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label);
        }
    }
}