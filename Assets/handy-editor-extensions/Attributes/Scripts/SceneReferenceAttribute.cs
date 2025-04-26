using System;
using UnityEngine;

namespace HandyEditorExtensions
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = true)]
    public class SceneReferenceAttribute : PropertyAttribute
    {
        
    }
}
