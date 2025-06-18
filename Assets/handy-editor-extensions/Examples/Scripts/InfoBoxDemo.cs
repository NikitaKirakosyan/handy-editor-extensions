using UnityEngine;

namespace HandyEditorExtensions.Demo
{
    public class InfoBoxDemo : MonoBehaviour
    {
        [InfoBox("This is info message", InfoBoxType.Info)]
        public float anotherValue;
        
        [InfoBox("This is warning message", InfoBoxType.Warning)]
        public Vector3 otherValue;
        
        [InfoBox("This is error message", InfoBoxType.Error)]
        public double errorValue;
    }
}