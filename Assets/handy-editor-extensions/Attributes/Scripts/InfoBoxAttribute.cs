using UnityEditor;
using UnityEngine;

namespace HandyEditorExtensions
{
    public class InfoBoxAttribute : PropertyAttribute
    {
        public readonly string message;
        public readonly MessageType messageType;


        public InfoBoxAttribute(string message, MessageType messageType = MessageType.Info)
        {
            this.message = message;
            this.messageType = messageType;
        }
    }
}