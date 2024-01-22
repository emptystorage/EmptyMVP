using UnityEditor;

namespace EmptyMVP
{
    public static class CreateScriptTemplatesEmptyMVP
    {
        [MenuItem("Assets/Create/EmptyMVP/New Presentor", priority = 10)]
        public static void CreateNewPresentorClass()
        {
            string presentorTemplatePath = "Assets/EmptyMVP/Editor/EmptyMVP_NewPresentor.cs.txt";

            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(presentorTemplatePath, "NewPresentor.cs");
        }
    }
}

