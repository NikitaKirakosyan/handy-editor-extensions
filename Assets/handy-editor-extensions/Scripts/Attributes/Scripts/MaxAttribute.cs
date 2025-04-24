using System;
using UnityEngine;

namespace HandyEditorExtensions
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class MaxAttribute : PropertyAttribute
    {
        public readonly float max;
        public readonly string maxValuePropertyName;

        public MaxAttribute(float max)
        {
            this.max = max;
        }

        public MaxAttribute(string maxValuePropertyName)
        {
            this.maxValuePropertyName = maxValuePropertyName;
        }
    }
}
