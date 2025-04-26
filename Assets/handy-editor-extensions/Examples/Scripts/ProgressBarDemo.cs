using UnityEngine;

namespace HandyEditorExtensions.Demo
{
    public class ProgressBarDemo : MonoBehaviour
    {
        [ProgressBar(0, 100)]
        public float progress1;

        public float minValue1 = -10;
        public float maxValue1 = 10;
        [ProgressBar(nameof(minValue1), nameof(maxValue1))] public float progress2;
    }
}