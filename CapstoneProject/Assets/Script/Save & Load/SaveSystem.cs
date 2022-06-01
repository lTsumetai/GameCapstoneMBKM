using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public static class SaveSystem
{
    public static void SaveGame(LevelManager lManager)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        // mengtur lokasi data
        string path = Application.persistentDataPath + "/dataGame.mantap";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(lManager);

        formatter.Serialize(stream, data);
        stream.Close();

        Debug.Log("Berhasil menyimpan data");
    }

    public static GameData LoadGame()
    {
        string path = Application.persistentDataPath + "/dataGame.mantap";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            Debug.Log("Berhasil mengambil data");

            return data;
        }
        else
        {
            Debug.LogError("Data Game tidak di temukan di " + path);
            return null;
        }
    }

    /*public static GameData cekLoadGame()
    {
        string path = Application.persistentDataPath + "/dataGame.mantap";
        if (File.Exists(path))
        {
            return ;
        }
        else
        {
            return 0;
        }
            
    }*/

}
