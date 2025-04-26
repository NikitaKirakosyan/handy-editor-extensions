using UnityEngine;

namespace HandyEditorExtensions.Demo
{
    public class ButtonDemo : MonoBehaviour
    {
        //showing as "Public Demo Button 1"
        [Button]
        public void PublicDemoButton1()
        {
            Debug.Log("PublicDemoButton1 clicked!");
        }

        //showing as "Private Demo Button 2"
        [Button]
        private void PrivateDemoButton2()
        {
            Debug.Log("PrivateDemoButton2 clicked!");
        }

        //not showing
        [Button]
        private static void PrivateStaticDemoButton3()
        {
            Debug.Log("You can't invoke this from inspector by Button attribute");
        }

        //showing as "Custom button name"
        [Button("Custom button name")]
        public void CustomPublicDemoButtonName()
        {
            Debug.Log("CustomPublicDemoButtonName clicked!");
        }
        
        //warning
        [Button]
        private void IncorrectButtonAttributeUsing(string[] someParams)
        {
            Debug.Log("IncorrectButtonAttributeUsing");
        }
    }
}