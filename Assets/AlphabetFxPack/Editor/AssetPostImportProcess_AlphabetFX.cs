using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Orangedkeys.AlphabetFX;
using System.IO;

// Set the scale of all the imported models to  "globalScaleModifier"
// and dont generate materials for the imported objects

public class AssetPostImportProcess_AlphabetFX : AssetPostprocessor
{
    static private bool WelcomeWin = false;
    static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {

        foreach (string item in importedAssets)
        {
            if (Path.GetFileName(item) == "AssetPostImportProcess_AlphabetFX.cs") WelcomeWin = true;
            
        }

        foreach (string itemdel in deletedAssets)
        {
            if (Path.GetFileName(itemdel) == "AssetPostImportProcess_AlphabetFX.cs") WelcomeWin = false;
            
        }

        if (WelcomeWin)
        {
            Debug.Log("AlphabetFX PACK IMPORTED !!");
            Welcome_AlphabetFX.ShowWindow();
        }


    }

}