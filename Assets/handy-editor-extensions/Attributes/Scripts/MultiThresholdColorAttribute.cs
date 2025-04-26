using System;
using UnityEngine;

namespace HandyEditorExtensions
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class MultiThresholdColorAttribute : PropertyAttribute
    {
        public readonly ThresholdColorMode mode;
        public readonly float[] thresholds;
        public readonly string[] colorHexes;

        
        public MultiThresholdColorAttribute(float[] thresholds, string[] colorHexes, ThresholdColorMode mode = ThresholdColorMode.Label)
        {
            if(thresholds == null || colorHexes == null || thresholds.Length != colorHexes.Length)
                throw new ArgumentException("thresholds and colorHexes can't be null or empty and must have the same length!");

            this.thresholds = thresholds;
            this.colorHexes = colorHexes;
            this.mode = mode;
        }
    }

    public enum ThresholdColorMode
    {
        Label,
        Background
    }
}