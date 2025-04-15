using UnityEditor;

public class OpenProBuilderFull
{
    [MenuItem("Tools/ProBuilder/Open Full ProBuilder Window")]
    static void OpenWindow()
    {
        EditorApplication.ExecuteMenuItem("Tools/ProBuilder/ProBuilder Window");
    }
}
