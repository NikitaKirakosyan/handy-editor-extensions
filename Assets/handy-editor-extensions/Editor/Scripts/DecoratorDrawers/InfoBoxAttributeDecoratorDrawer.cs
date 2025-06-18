#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace HandyEditorExtensions.Editor
{
    [CustomPropertyDrawer(typeof(InfoBoxAttribute))]
    public class InfoBoxAttributeDecoratorDrawer : DecoratorDrawer
    {
        public override void OnGUI(Rect pos)
        {
            var attr = (InfoBoxAttribute)attribute;
            var messageType = GetMessageType(attr.infoBoxType);
            EditorGUI.HelpBox(pos, attr.message, messageType);
        }

        public override float GetHeight()
        {
            return EditorGUIUtility.singleLineHeight * 2 + EditorGUIUtility.standardVerticalSpacing;
        }


        private MessageType GetMessageType(InfoBoxType infoBoxType)
        {
            switch(infoBoxType)
            {
                case InfoBoxType.Warning:
                    return MessageType.Warning;
                case InfoBoxType.Error:
                    return MessageType.Error;
                default:
                    return MessageType.Info;
            }
        }
    }
}
#endif