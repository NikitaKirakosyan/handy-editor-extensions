using UnityEngine;

namespace HandyEditorExtensions
{
    public class ProgressBarAttribute : PropertyAttribute
    {
        public readonly string minValueFieldName;
        public readonly string maxValueFieldName;
        public readonly float minValue;
        public readonly float maxValue;


        public ProgressBarAttribute(string minValueFieldName, string maxValueFieldName)
        {
            this.minValueFieldName = minValueFieldName;
            this.maxValueFieldName = maxValueFieldName;
        }

        public ProgressBarAttribute(float minValue, float maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }
    }
}