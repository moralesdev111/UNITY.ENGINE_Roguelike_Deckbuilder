using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer(Player2D player2D)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.save";

        FileStream stream = new FileStream(path,FileMode.Create);

        PathSceneSaveData pathSceneSaveData = new PathSceneSaveData(player2D);

        formatter.Serialize(stream, pathSceneSaveData);
        stream.Close();
    }

    public static PathSceneSaveData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.save";

        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

        PathSceneSaveData  pathSceneSaveData = formatter.Deserialize(stream) as PathSceneSaveData;
        stream.Close();
        return pathSceneSaveData;
        }
        else
        {
            Debug.Log("Save file not found in" + path);
            return null;
        }
    }
}

