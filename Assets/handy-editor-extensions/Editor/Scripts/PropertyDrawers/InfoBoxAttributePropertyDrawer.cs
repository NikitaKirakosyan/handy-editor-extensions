using UnityEditor;
using UnityEngine;

namespace HandyEditorExtensions.Editor
{
    [CustomPropertyDrawer(typeof(InfoBoxAttribute))]
    public class InfoBoxAttributePropertyDrawer : DecoratorDrawer
    {
        public override void OnGUI(Rect pos)
        {
            var attr = (InfoBoxAttribute)attribute;
            EditorGUI.HelpBox(pos, attr.message, attr.messageType);
        }

        public override float GetHeight()
        {
            return EditorGUIUtility.singleLineHeight * 2 + EditorGUIUtility.standardVerticalSpacing;
        }
    }
}