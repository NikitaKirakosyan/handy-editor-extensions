using System;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace HandyEditorExtensions.Editor
{
    [CustomPropertyDrawer(typeof(TagDropdownAttribute))]
    public class TagDropdownAttributePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect pos, SerializedProperty prop, GUIContent label)
        {
            if(prop.propertyType != SerializedPropertyType.String)
            {
                EditorGUI.PropertyField(pos, prop, label);
                return;
            }

            var tags = InternalEditorUtility.tags;
            var idx = Array.IndexOf(tags, prop.stringValue);
            idx = EditorGUI.Popup(pos, label.text, idx < 0 ? 0 : idx, tags);
            prop.stringValue = tags[idx];
        }
    }
}