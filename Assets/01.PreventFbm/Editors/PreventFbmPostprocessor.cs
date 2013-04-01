using UnityEngine;
using UnityEditor;
using System.IO;

public class PreventFbmPostprocessor : AssetPostprocessor {

    static void OnPostprocessAllAssets(
        string[] importedAssets,
        string[] deletedAssets,
        string[] movedAssets, string[] movedFromAssetPaths)
    {

        foreach (string path in importedAssets)
        {
            if (path.EndsWith(".fbm"))
            {
                Debug.LogError("fbm 생성은 허용되지 않습니다. " + path);
                Directory.Delete(path, true);
                File.Delete(path + ".meta");

            }
        }
    }
}
