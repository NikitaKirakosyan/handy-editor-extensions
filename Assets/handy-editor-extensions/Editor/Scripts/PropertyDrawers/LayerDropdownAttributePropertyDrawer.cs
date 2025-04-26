using System;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace HandyEditorExtensions.Editor
{
    [CustomPropertyDrawer(typeof(LayerDropdownAttribute))]
    public class LayerDropdownAttributePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect pos, SerializedProperty prop, GUIContent label)
        {
            if(prop.propertyType != SerializedPropertyType.Integer)
            {
                EditorGUI.PropertyField(pos, prop, label);
                return;
            }

            var layers = InternalEditorUtility.layers;
            var currentName = LayerMask.LayerToName(prop.intValue);
            var idx = Array.IndexOf(layers, currentName);
            idx = EditorGUI.Popup(pos, label.text, idx < 0 ? 0 : idx, layers);
            prop.intValue = LayerMask.NameToLayer(layers[idx]);
        }
    }
}