using System;
using UnityEngine;

namespace HandyEditorExtensions
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public abstract class VisibilityAttributeBase : PropertyAttribute
    {
        public readonly bool condition;
        public readonly string conditionPropertyName;

        
        public VisibilityAttributeBase(bool condition)
        {
            this.condition = condition;
        }
        
        public VisibilityAttributeBase(string conditionPropertyName)
        {
            this.conditionPropertyName = conditionPropertyName;
        }
    }
}
