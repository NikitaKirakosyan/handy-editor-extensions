using UnityEditor;
using UnityEngine;

namespace HandyEditorExtensions.Demo
{
    public class InfoBoxDemo : MonoBehaviour
    {
        [InfoBox("This is none message", MessageType.None)]
        public int someValue;

        [InfoBox("This is info message", MessageType.Info)]
        public float anotherValue;
        
        [InfoBox("This is warning message", MessageType.Warning)]
        public Vector3 otherValue;
        
        [InfoBox("This is error message", MessageType.Error)]
        public double errorValue;
    }
}