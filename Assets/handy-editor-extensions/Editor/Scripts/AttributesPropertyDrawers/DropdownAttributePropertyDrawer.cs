using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace HandyEditorExtensions.Editor
{
    [CustomPropertyDrawer(typeof(DropdownAttribute))]
    public class DropdownAttributePropertyDrawer : PropertyDrawer
    {
        private List<string> _dropdownValues;
        private string[] _dropdownValuesArray;
        private readonly string _defaultId = null;

        private Type StaticType => DropdownAttribute.type;
        private DropdownAttribute DropdownAttribute => attribute as DropdownAttribute;


        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginChangeCheck();
            
            GetDropdownValues();

            var currentIndex = _dropdownValues.IndexOf(property.stringValue);
            if(currentIndex == -1)
                currentIndex = _dropdownValues.IndexOf(_defaultId);
            
            var selectedIndex = EditorGUI.Popup(position, label.text, currentIndex, _dropdownValuesArray);
            if(EditorGUI.EndChangeCheck())
                property.stringValue = selectedIndex != -1 ? _dropdownValues[selectedIndex] : _defaultId;
        }


        private void GetDropdownValues()
        {
            if(_dropdownValues != null)
                return;

            _dropdownValues = new List<string>();

            var fields = StaticType.GetFields(BindingFlags.Public | BindingFlags.Static);
            foreach(var field in fields)
                _dropdownValues.Add((string)field.GetValue(null));

            _dropdownValuesArray = _dropdownValues.ToArray();
        }
    }
}