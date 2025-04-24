using UnityEngine;

namespace HandyEditorExtensions
{
    public class PlayerDemo : MonoBehaviour
    {
        [Header("Max")]
        [Max(100)] public int health100 = 100;
        [Max(nameof(maxHealth))] public int healthByMaxHealth = 100;
        public int maxHealth = 200;
        
        [Header("ReadOnly")]
        [ReadOnly] public string readOnlyStringField = "read only string field";
        [ReadOnly] public Vector3 readOnlyVector3Field = new (1, 2, 3);
        
        [Header("ShowIf and HideIf")]
        public bool showIf = true;
        public bool hideIf = true;
        [ShowIf(true)] public int visibleInt = 1;
        [ShowIf(false)] public int unvisibleInt = 2;
        [ShowIf(nameof(showIf))] public int visibleIntByShowIf = 3;
        [HideIf(nameof(hideIf))] public int visibleIntByHideIf = 4;
    }
}