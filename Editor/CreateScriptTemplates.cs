using System.IO;
using UnityEditor;

public static class CreateScriptTemplates 
{
    [MenuItem("Assets/Create/EmptyMVP/New Presentor", priority = 10)]
    public static void CreateNewPresentorClass()
    {
        string presentorTemplatePath = "Assets/EmptyMVP/Editor/EmptyMVP_NewPresentor.cs.txt";

        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(presentorTemplatePath, "NewPresentor.cs");
    }
}
