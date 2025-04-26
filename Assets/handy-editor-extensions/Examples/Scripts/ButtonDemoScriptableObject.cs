using UnityEngine;

namespace HandyEditorExtensions.Demo
{
    public class ButtonDemoScriptableObject : ScriptableObject
    {
        [Button]
        public void ScriptableDemoButton1()
        {
            Debug.Log("Button1 clicked!");
        }
        
        [Button("Scriptable Button")]
        private void ScriptableDemoButton2()
        {
            Debug.Log("Button2 clicked!");
        }
    }
}
