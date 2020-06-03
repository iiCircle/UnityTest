using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Test{

    [MenuItem("Tool/Build")]
    public static void BuildTest()
    {
        Debug.Log("========================================================");
        Debug.Log("BuildTest");
        Debug.Log("========================================================");



        string path = "/data/qqq.apk";
        Debug.Log("========================================================");
        Debug.Log(path);
        Debug.Log("========================================================");
        Debug.Log(BuildPipeline.BuildPlayer(GetBuildScenes(), path, BuildTarget.Android, BuildOptions.None));
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
