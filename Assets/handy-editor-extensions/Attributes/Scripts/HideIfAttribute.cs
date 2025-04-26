using System;
using UnityEngine;

namespace HandyEditorExtensions
{
    public class HideIfAttribute : VisibilityAttributeBase
    {
        public HideIfAttribute(bool condition) : base(condition)
        {
        }

        public HideIfAttribute(string conditionPropertyName) : base(conditionPropertyName)
        {
        }
    }
}
