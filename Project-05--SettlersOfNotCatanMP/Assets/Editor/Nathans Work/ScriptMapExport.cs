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

    public static ScriptHex[][] hexMap;

    public static void ExportMap()
    {
        InitializeDefaults();
        WriteToFile();
    }

    //Writes relevent data to the file inside of Maps/Custom with the title of LevelName.txt
    static void WriteToFile()
    {
        hexMap = ScriptMapCreationWindow.hexMap;
        int lineNum = 0;
        if (levelName.Contains(" "))
        {
            levelName = levelName.Replace(" ", "_");
            Debug.Log(levelName);
        }
        path = path + levelName + ".txt";

        writer = new StreamWriter(path);
        using(writer)
        {
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    writer.WriteLine(levelName);
                }
                else
                {
                    writer.WriteLine(authorName);
                }
            }
            //for (int i = 0; i < hexMap.GetLength(0); i++)
            //{
            //    for (int j = 0; j < hexMap.GetLength(1); j++)
            //    {
            //        writer.WriteLine(hexMap[i][j].hexType + "_" + i + "," + j + "_" + hexMap[i][j].hexNum);
            //    }
            //}
        }
    }

    static void InitializeDefaults()
    {
        levelName = "Level Name";
        authorName = "Author Name";
        path = Application.dataPath + "/Maps/Custom/";
        hexMap = new ScriptHex[15][];
    }
}
