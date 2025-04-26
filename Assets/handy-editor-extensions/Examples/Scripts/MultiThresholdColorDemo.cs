using UnityEngine;

namespace HandyEditorExtensions.Demo
{
    public class MultiThresholdColorDemo : MonoBehaviour
    {
        private const string RedHexColor = "#FF0000";
        private const string GreenHexColor = "#00FF00";
        private const string YellowHexColor = "#FFFF00";
        private const string BlueHexColor = "#0000FF";
        private const string CyanHexColor = "#00FFFF";
        private const string MagentaHexColor = "#FF00FF";
        
        
        [MultiThresholdColor(new float[] { 0f, 50f, 100f }, new string[] { RedHexColor, YellowHexColor, GreenHexColor })]
        public float healthWithLabel;

        [MultiThresholdColor(new float[] { 0f, 25f, 75f }, new string[] { BlueHexColor, YellowHexColor, GreenHexColor }, ThresholdColorMode.Background)]
        public float staminaWithBackground;

        [MultiThresholdColor(new float[] { 0f, 25f, 75f }, new string[] { MagentaHexColor, CyanHexColor, BlueHexColor })]
        public int armor;
    }
}