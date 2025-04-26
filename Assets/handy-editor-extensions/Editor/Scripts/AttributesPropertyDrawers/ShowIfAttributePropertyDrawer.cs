using UnityEditor;
using UnityEngine;

namespace HandyEditorExtensions.Editor
{
    [CustomPropertyDrawer(typeof(ShowIfAttribute))]
    public class ShowIfAttributePropertyDrawer : NameAndValuePropertyDrawerBase
    {
        private ShowIfAttribute ShowIfAttribute => attribute as ShowIfAttribute;
        private bool HasConditionPropertyName => !string.IsNullOrEmpty(ShowIfAttribute.conditionPropertyName) && !string.IsNullOrWhiteSpace(ShowIfAttribute.conditionPropertyName);


        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginChangeCheck();

            if(HasConditionPropertyName)
                DrawAttributeOnPropertyNameBased(position, property, label);
            else
                DrawAttributeOnValueBased(position, property, label);

            EditorGUI.EndChangeCheck();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            bool shouldShow;
            if(HasConditionPropertyName)
            {
                var condProp = property.serializedObject.FindProperty(ShowIfAttribute.conditionPropertyName);
                shouldShow = condProp is { boolValue: true };
            }
            else
            {
                shouldShow = ShowIfAttribute.condition;
            }

            if(!shouldShow)
                return 0f;

            return EditorGUI.GetPropertyHeight(property, label, true);
        }


        protected override void DrawAttributeOnPropertyNameBased(Rect position, SerializedProperty property, GUIContent label)
        {
            var serializedProperty = property.serializedObject.FindProperty(ShowIfAttribute.conditionPropertyName);
            var condition = serializedProperty.boolValue;
            if(condition)
                EditorGUI.PropertyField(position, property, label);
        }

        protected override void DrawAttributeOnValueBased(Rect position, SerializedProperty property, GUIContent label)
        {
            var condition = ShowIfAttribute.condition;
            if(condition)
                EditorGUI.PropertyField(position, property, label);
        }
    }
}