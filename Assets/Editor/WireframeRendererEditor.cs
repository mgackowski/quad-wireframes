using UnityEditor;
using UnityEngine.UIElements;

[CustomEditor(typeof(WireframeRenderer))]
[CanEditMultipleObjects]
public class WireframeRendererEditor : Editor
{
    VisualTreeAsset uxml;
    WireframeRenderer script;

    void OnEnable()
    {
        script = (WireframeRenderer)target;
        uxml = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(
            AssetDatabase.GUIDToAssetPath("f9b999c365f46394fae29b82be27e75a"));
    }

    public override VisualElement CreateInspectorGUI()
    {
        VisualElement inspector = new VisualElement();
        uxml.CloneTree(inspector);

        /* Add behaviour to buttons */
        inspector.Query<Button>("prepareButton").First().clicked += script.PrepareLineSegments;
        inspector.Query<Button>("prepareAllButton").First().clicked += script.PrepareAllInScene;

        return inspector;
    }
}