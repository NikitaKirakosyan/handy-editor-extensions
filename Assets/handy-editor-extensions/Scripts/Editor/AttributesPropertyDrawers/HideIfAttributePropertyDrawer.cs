using UnityEditor;
using UnityEngine;

namespace HandyEditorExtensions.Editor
{
    [CustomPropertyDrawer(typeof(HideIfAttribute))]
    public class HideIfAttributePropertyDrawer : NameAndValuePropertyDrawerBase
    {
        private HideIfAttribute HideIfAttribute => attribute as HideIfAttribute;
        private bool HasConditionPropertyName => !string.IsNullOrEmpty(HideIfAttribute.conditionPropertyName) && !string.IsNullOrWhiteSpace(HideIfAttribute.conditionPropertyName);
        
        
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
                var condProp = property.serializedObject.FindProperty(HideIfAttribute.conditionPropertyName);
                shouldShow = condProp is { boolValue: false };
            }
            else
            {
                shouldShow = !HideIfAttribute.condition;
            }

            if(!shouldShow)
                return 0f;

            return EditorGUI.GetPropertyHeight(property, label, true);
        }
        
        
        protected override void DrawAttributeOnPropertyNameBased(Rect position, SerializedProperty property, GUIContent label)
        {
            var serializedProperty = property.serializedObject.FindProperty(HideIfAttribute.conditionPropertyName);
            var condition = serializedProperty.boolValue;
            if(!condition)
                EditorGUI.PropertyField(position, property, label);
        }

        protected override void DrawAttributeOnValueBased(Rect position, SerializedProperty property, GUIContent label)
        {
            var condition = HideIfAttribute.condition;
            if(!condition)
                EditorGUI.PropertyField(position, property, label);
        }
    }
}
