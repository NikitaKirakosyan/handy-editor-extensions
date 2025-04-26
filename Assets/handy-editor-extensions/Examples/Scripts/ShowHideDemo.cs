using UnityEngine;

namespace HandyEditorExtensions.Demo
{
    public class ShowHideDemo : MonoBehaviour
    {
        [Header("ShowIf and HideIf")]
        public bool showIf = true;
        public bool hideIf = true;
        [ShowIf(true)] public int visibleInt = 1;
        [ShowIf(false)] public int unvisibleInt = 2;
        [ShowIf(nameof(showIf))] public int visibleIntByShowIf = 3;
        [HideIf(nameof(hideIf))] public int visibleIntByHideIf = 4;
    }
}
