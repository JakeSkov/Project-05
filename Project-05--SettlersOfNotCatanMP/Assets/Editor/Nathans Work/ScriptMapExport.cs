using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// @Author Jake Skov
/// @Desc Handles the export of the custom map
/// </summary>
public class ScriptMapExport : MonoBehaviour 
{
    public static string levelName;
    public static string authorName;

    private static string path = Application.dataPath + "Maps/Custom/";
    private static StreamWriter writer;

    public static void ExportMap()
    {
        InitializeDefaults();
        WriteToFile();
    }

    static void WriteToFile()
    {
        int lineNum;
        int numLines = 
        if (levelName.Contains(" "))
        {
            levelName = levelName.Replace(" ", "_");
            Debug.Log(levelName);
        }
        path = path + levelName + ".txt";

        writer = new StreamWriter(path);

    }

    static void InitializeDefaults()
    {
        levelName = "Level Name";
        authorName = "Author Name";
        path = Application.dataPath + "Maps/Custom/";
    }
}
