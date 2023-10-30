using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(WireframeRenderer))]
public class WireframeRendererEditor : Editor
{
    public override void OnInspectorGUI()
    {
        WireframeRenderer script = (WireframeRenderer)target;

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Prepare wireframe for object"))
        {
            script.PrepareLineSegments();
        }
        if (GUILayout.Button("Prepare wireframe for all in scene"))
        {
            script.PrepareAllInScene();
        }
        EditorGUILayout.EndHorizontal();

        DrawDefaultInspector();

    }

}
