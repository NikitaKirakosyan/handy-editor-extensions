using UnityEngine;

namespace HandyEditorExtensions
{
    public class InfoBoxAttribute : PropertyAttribute
    {
        public readonly string message;
        public readonly InfoBoxType infoBoxType;


        public InfoBoxAttribute(string message, InfoBoxType infoBoxType = InfoBoxType.Info)
        {
            this.message = message;
            this.infoBoxType = infoBoxType;
        }
    }
}