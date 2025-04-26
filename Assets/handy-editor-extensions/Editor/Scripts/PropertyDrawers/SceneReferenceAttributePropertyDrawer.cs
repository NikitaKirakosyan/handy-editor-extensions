using UnityEditor;
using UnityEngine;

namespace HandyEditorExtensions.Editor
{
    [CustomPropertyDrawer(typeof(SceneReferenceAttribute))]
    public class SceneReferenceAttributePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect pos, SerializedProperty prop, GUIContent label)
        {
            if(prop.propertyType != SerializedPropertyType.String)
            {
                EditorGUI.PropertyField(pos, prop, label);
                return;
            }

            EditorGUI.BeginProperty(pos, label, prop);

            var asset = AssetDatabase.LoadAssetAtPath<SceneAsset>(prop.stringValue);
            var scene = (SceneAsset)EditorGUI.ObjectField(pos, label, asset, typeof(SceneAsset), false);

            if(scene != asset)
                prop.stringValue = AssetDatabase.GetAssetPath(scene);

            EditorGUI.EndProperty();
        }
    }
}