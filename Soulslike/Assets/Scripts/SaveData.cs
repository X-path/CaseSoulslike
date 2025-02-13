using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public Vector3 position;
    public int health;
    public int gold;
    public int storyProgress;
    public int checkPointId;
    public List<Vector3> checkpoints;
}

public static class SaveSystem
{
    public static void SaveGame(PlayerData player)
    {
        SaveData data = new SaveData
        {
            position = player.GetPos(),
            health = player.health,
            gold = player.gold,
            storyProgress = player.storyProgress,
            checkPointId = player.checkPointId,
            checkpoints = new List<Vector3>(player.GetActiveCheckpoints())
    };

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public static SaveData LoadGame()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            return JsonUtility.FromJson<SaveData>(json);
        }
        return null;
    }
}
