using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(WireframeRenderer))]
public class WireframeRendererEditor : Editor
{
    public override void OnInspectorGUI()
    {
        WireframeRenderer script = (WireframeRenderer)target;

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Prepare wireframe"))
        {
            script.PrepareLineSegments();
        }
        EditorGUILayout.EndHorizontal();

        DrawDefaultInspector();

    }

}
