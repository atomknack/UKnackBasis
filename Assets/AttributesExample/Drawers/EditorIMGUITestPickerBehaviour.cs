using UnityEditor;

[CustomEditor(typeof(IMGUITestPickerBehaviour))]
[CanEditMultipleObjects]
public class EditorIMGUITestPickerBehaviour : Editor
{
    SerializedProperty notNullWithInterfacePicker;

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        EditorGUILayout.LabelField("IMGUI custom inspector:");
        DrawPropertySlow("notNullWithInterfacePicker");
        DrawPropertySlow("notNull");
        DrawPropertySlow("interfaceOnObject");
        DrawPropertySlow("behaviourOnObject");
        DrawPropertySlow("shouldHaveChild");
        DrawPropertySlow("manyPickersForObjectThatHaveChild");
        DrawPropertySlow("manyPickersForNotNull");
        DrawPropertySlow("shorty");
        serializedObject.ApplyModifiedProperties();
    }

    private void DrawPropertySlow(string name)
    {
        EditorGUILayout.PropertyField(serializedObject.FindProperty(name));
    }
}
