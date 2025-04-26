using UnityEngine;

namespace HandyEditorExtensions.Demo
{
    public class ReadOnlyDemo : MonoBehaviour
    {
        [Header("ReadOnly")]
        [ReadOnly] public string readOnlyStringField = "read only string field";
        [ReadOnly] public Vector3 readOnlyVector3Field = new (1, 2, 3);
    }
}
