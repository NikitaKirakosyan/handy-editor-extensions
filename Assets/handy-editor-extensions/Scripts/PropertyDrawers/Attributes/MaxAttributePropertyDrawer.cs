using UnityEditor;
using UnityEngine;

namespace HandyEditorExtensions
{
    [CustomPropertyDrawer(typeof(MaxAttribute))]
    public class MaxAttributePropertyDrawer : PropertyDrawer
    {
        private const string InvalidTypeMessage = "Use Max with numeric type like float, int or double and etc.";

        private MaxAttribute MaxAttribute => attribute as MaxAttribute;


        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginChangeCheck();
            EditorGUI.PropertyField(position, property, label);
            if(!EditorGUI.EndChangeCheck())
                return;

            if(!string.IsNullOrEmpty(MaxAttribute.maxValuePropertyName) && !string.IsNullOrWhiteSpace(MaxAttribute.maxValuePropertyName))
                DrawMaxAttributeOnPropertyNameBased(position, property, label);
            else
                DrawMaxAttributeOnValueBased(position, property, label);
        }


        private void DrawMaxAttributeOnPropertyNameBased(Rect position, SerializedProperty property, GUIContent label)
        {
            var maxValueSerializedProperty = property.serializedObject.FindProperty(MaxAttribute.maxValuePropertyName);

            var maxValue = maxValueSerializedProperty.numericType switch
            {
                SerializedPropertyNumericType.Double => maxValueSerializedProperty.floatValue,
                SerializedPropertyNumericType.Float  => maxValueSerializedProperty.floatValue,
                _                                    => maxValueSerializedProperty.intValue,
            };
            
            Draw(position, property, label, maxValue, (int)maxValue);
        }

        private void DrawMaxAttributeOnValueBased(Rect position, SerializedProperty property, GUIContent label)
        {
            Draw(position, property, label, MaxAttribute.max, (int)MaxAttribute.max);
        }

        private void Draw(Rect position, SerializedProperty property, GUIContent label, float maxValueF, int maxValueInt)
        {
            switch(property.propertyType)
            {
                case SerializedPropertyType.Float:
                    property.floatValue = Mathf.Min(maxValueF, property.floatValue);
                    break;
                case SerializedPropertyType.Integer:
                    property.intValue = Mathf.Min(maxValueInt, property.intValue);
                    break;
                case SerializedPropertyType.Vector2:
                {
                    var vector2Value = property.vector2Value;
                    property.vector2Value = new Vector2(Mathf.Min(maxValueF, vector2Value.x), Mathf.Min(maxValueF, vector2Value.y));
                    break;
                }
                case SerializedPropertyType.Vector2Int:
                {
                    var vector2IntValue = property.vector2IntValue;
                    property.vector2IntValue = new Vector2Int(Mathf.Min(maxValueInt, vector2IntValue.x), Mathf.Min(maxValueInt, vector2IntValue.y));
                    break;
                }
                case SerializedPropertyType.Vector3:
                {
                    var vector3Value = property.vector3Value;
                    property.vector3Value = new Vector3(Mathf.Min(maxValueF, vector3Value.x), Mathf.Min(maxValueF, vector3Value.y),
                        Mathf.Min(maxValueF, vector3Value.z));
                    break;
                }
                case SerializedPropertyType.Vector3Int:
                {
                    var vector3IntValue = property.vector3IntValue;
                    property.vector3IntValue = new Vector3Int(Mathf.Min(maxValueInt, vector3IntValue.x), Mathf.Min(maxValueInt, vector3IntValue.y),
                        Mathf.Min(maxValueInt, vector3IntValue.z));
                    break;
                }
                case SerializedPropertyType.Vector4:
                {
                    var vector4Value = property.vector4Value;
                    property.vector4Value = new Vector4(Mathf.Min(maxValueF, vector4Value.x), Mathf.Min(maxValueF, vector4Value.y),
                        Mathf.Min(maxValueF, vector4Value.z), Mathf.Min(maxValueF, vector4Value.w));
                    break;
                }
                default:
                    EditorGUI.LabelField(position, label.text, InvalidTypeMessage);
                    break;
            }
        }
    }
}