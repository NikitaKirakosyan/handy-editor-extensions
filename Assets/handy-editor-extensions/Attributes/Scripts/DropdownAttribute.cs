using System;
using UnityEngine;

namespace HandyEditorExtensions
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class DropdownAttribute : PropertyAttribute
    {
        public readonly Type type;

        
        public DropdownAttribute(Type type)
        {
            this.type = type;
        }
    }
}
