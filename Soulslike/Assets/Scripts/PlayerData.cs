using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerData : MonoBehaviour
{
    public static PlayerData instance; 

    [SerializeField] Transform playerTransform;

    public Vector3 pos;
    public int health = 100;
    public int gold = 0;
    public int storyProgress = 0;
    public int checkPointId = 0;

    public List<Vector3> activeCheckpoints = new List<Vector3>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            SceneManager.sceneLoaded += OnSceneLoaded;

        }
        else
        {
            Destroy(gameObject);
        }

        
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        FindPlayerTransform();
    }

    void FindPlayerTransform()
    {
        PlayerMove player =FindObjectOfType<PlayerMove>();
        if (player != null)
        {
            playerTransform = player.transform;
        }
    }

    void Start()
    {
        SaveData data = SaveSystem.LoadGame();
        if (data != null)
        {
            LoadData(data);
            Debug.Log("Kayýt Yüklendi!");
        }
        else
        {
            Debug.Log("Kayýt Bulunamadý, yeni oyun baþlatýldý.");
        }

        UIManager.instance.UpdateSavedInformation();
        UIManager.instance.UpdateUnsavedInformation();
    }

    public void LoadData(SaveData data)
    {
        playerTransform.position = data.position;
        health = data.health;
        gold = data.gold;
        storyProgress = data.storyProgress;
        activeCheckpoints = data.checkpoints??new List<Vector3>();
        
    }

    public void AddCheckpoint(Vector3 checkpointPos)
    {
        if (!activeCheckpoints.Contains(checkpointPos))
        {
            activeCheckpoints.Add(checkpointPos);
           
        }
    }

    public List<Vector3> GetActiveCheckpoints()
    {
        return new List<Vector3>(activeCheckpoints);
    }


    public void ChangePos(Vector3 position)
    {
        pos = position;
        UIManager.instance.UpdateUnsavedInformation();
    }
    public void ChangeHealth(int amount)
    {
        health += amount;
        if (health < 0) health = 0;
        UIManager.instance.UpdateUnsavedInformation();
    }

    public void ChangeGold(int amount)
    {
        gold += amount;
        if (gold < 0) gold = 0;
        UIManager.instance.UpdateUnsavedInformation();
    }

    public void ChangeStoryProgress(int progress)
    {
        if(storyProgress+progress<=100)
        {
            storyProgress += progress;
            UIManager.instance.UpdateUnsavedInformation();
        }
        
    }
    public void ChangePointId(int id)
    {
        checkPointId = id;
        UIManager.instance.UpdateUnsavedInformation();
    }

    public Vector3 GetPos()
    {
        pos = playerTransform.position;
        return pos;
    }
    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
