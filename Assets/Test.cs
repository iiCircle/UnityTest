using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Test{

    public static void BuildTest()
    {
        Debug.LogError("========================================================");
        Debug.LogError("BuildTest");
        Debug.LogError("========================================================");



        string path = string.Format(Application.dataPath + "/wsds.apk");
        Debug.LogError("========================================================");
        Debug.LogError(path);
        Debug.LogError("========================================================");
        BuildPipeline.BuildPlayer(GetBuildScenes(), path, BuildTarget.Android, BuildOptions.None);
    }

           static string[] GetBuildScenes()
        {
                List<string> names = new List<string>();
                foreach(EditorBuildSettingsScene e in EditorBuildSettings.scenes)
                {
                        if(e==null)
                                continue;
                        if(e.enabled)
                                names.Add(e.path);
                }
                return names.ToArray();
        }
}
