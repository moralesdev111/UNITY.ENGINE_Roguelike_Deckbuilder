using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[CreateAssetMenu(fileName = "ClearSaveFile", menuName ="ScriptableObjects/ClearSaveFile")]
public class ClearSaveFile : ScriptableObject
{
    
     public void ClearSaveFiles()
    {
        string savePath = Application.persistentDataPath + "/player.save";

        if (File.Exists(savePath))
        {
            File.Delete(savePath);
            Debug.Log("Save file deleted for debugging purposes.");
        }
        else
        {
            Debug.Log("No save file found.");
        }
    }
}
