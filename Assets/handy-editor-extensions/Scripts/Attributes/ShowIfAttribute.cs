using System;
using UnityEngine;

namespace HandyEditorExtensions
{
    public class ShowIfAttribute : VisibilityAttributeBase
    {
        public ShowIfAttribute(bool condition) : base(condition)
        {
        }

        public ShowIfAttribute(string conditionPropertyName) : base(conditionPropertyName)
        {
        }
    }
}
