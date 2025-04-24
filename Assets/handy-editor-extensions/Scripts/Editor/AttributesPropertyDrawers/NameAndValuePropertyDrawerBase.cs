using UnityEditor;
using UnityEngine;

namespace HandyEditorExtensions.Editor
{
    public abstract class NameAndValuePropertyDrawerBase : PropertyDrawer
    {
        protected abstract void DrawAttributeOnPropertyNameBased(Rect position, SerializedProperty property, GUIContent label);

        protected abstract void DrawAttributeOnValueBased(Rect position, SerializedProperty property, GUIContent label);
    }
}
