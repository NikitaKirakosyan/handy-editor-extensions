using UnityEngine;
using UnityEditor;

namespace HandyEditorExtensions.Editor
{
    [CustomPropertyDrawer(typeof(ProgressBarAttribute))]
    public class ProgressBarAttributePropertyDrawer : PropertyDrawer
    {
        private ProgressBarAttribute ProgressBarAttribute => attribute as ProgressBarAttribute;


        public override void OnGUI(Rect pos, SerializedProperty prop, GUIContent label)
        {
            var so = prop.serializedObject;

            var min = ProgressBarAttribute.minValue;
            var max = ProgressBarAttribute.maxValue;

            if(!string.IsNullOrEmpty(ProgressBarAttribute.minValueFieldName) && !string.IsNullOrEmpty(ProgressBarAttribute.maxValueFieldName))
            {
                var minProp = so.FindProperty(ProgressBarAttribute.minValueFieldName);
                var maxProp = so.FindProperty(ProgressBarAttribute.maxValueFieldName);

                min = minProp is { propertyType: SerializedPropertyType.Float } ? minProp.floatValue : 0f;
                max = maxProp is { propertyType: SerializedPropertyType.Float } ? maxProp.floatValue : 1f;
            }

            var val = prop.propertyType switch
            {
                SerializedPropertyType.Float => prop.floatValue,
                _                            => prop.intValue
            };

            EditorGUI.BeginProperty(pos, label, prop);
            pos.height = EditorGUIUtility.singleLineHeight;
            EditorGUI.PropertyField(pos, prop, label);

            var barRect = new Rect(pos.x, pos.y + EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing, pos.width, EditorGUIUtility.singleLineHeight);
            var normalized = max > min ? (val - min) / (max - min) : 0;
            EditorGUI.ProgressBar(barRect, normalized, $"{val:F1} / {max:F1}");
            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty prop, GUIContent label)
        {
            return EditorGUIUtility.singleLineHeight * 2
                   + EditorGUIUtility.standardVerticalSpacing;
        }
    }
}