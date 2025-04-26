using System;
using UnityEngine;

namespace HandyEditorExtensions
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class TagDropdownAttribute : PropertyAttribute
    {
        
    }
}