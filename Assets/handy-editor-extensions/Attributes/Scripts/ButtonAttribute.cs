using System;

namespace HandyEditorExtensions
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class ButtonAttribute : Attribute
    {
        public readonly string buttonName;
        

        public ButtonAttribute(string buttonName = null)
        {
            this.buttonName = buttonName;
        }
    }
}
