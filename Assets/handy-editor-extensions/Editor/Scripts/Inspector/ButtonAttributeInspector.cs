using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace HandyEditorExtensions.Editor
{
    [CustomEditor(typeof(Object), true), CanEditMultipleObjects]
    public class ButtonAttributeInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            foreach(var t in targets)
            {
                var methods = t.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

                foreach(var method in methods)
                {
                    var attr = method.GetCustomAttribute<ButtonAttribute>();
                    if(attr == null)
                        continue;

                    if(method.GetParameters().Length > 0)
                    {
                        EditorGUILayout.HelpBox($"Method {method.Name} marked [Button] but has parameters — button will not be rendered.", MessageType.Warning);
                        continue;
                    }

                    var label = string.IsNullOrEmpty(attr.buttonName)
                        ? ObjectNames.NicifyVariableName(method.Name)
                        : attr.buttonName;

                    if(GUILayout.Button(label))
                    {
                        foreach(var tgt in targets)
                        {
                            method.Invoke(tgt, null);
                            if(tgt is Object uo)
                                EditorUtility.SetDirty(uo);
                        }
                    }
                }
            }
        }
    }
}