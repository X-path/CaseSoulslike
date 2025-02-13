using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public static UIManager instance; // UIManager

    [SerializeField] public GameObject mainPanel;

    [Header("SavedInformations")] // Header
    [SerializeField] public TextMeshProUGUI PlayerPosText;
    [SerializeField] public TextMeshProUGUI PlayerHealthText;
    [SerializeField] public TextMeshProUGUI PlayerGoldText;
    [SerializeField] public TextMeshProUGUI StoryProgressText;
    [SerializeField] public TextMeshProUGUI CheckPointIdText;

    [Header("UnsavedInformations")] // Header
    [SerializeField] public TextMeshProUGUI UnSavedPlayerPosText;
    [SerializeField] public TextMeshProUGUI UnSavedPlayerHealthText;
    [SerializeField] public TextMeshProUGUI UnSavedPlayerGoldText;
    [SerializeField] public TextMeshProUGUI UnSavedStoryProgressText;
    [SerializeField] public TextMeshProUGUI UnSavedCheckPointIdText;

    [SerializeField] public TextMeshProUGUI LevelText;

    [SerializeField] public List<Button> checkPointButtons = new List<Button>();

    private int storedCheckPointId;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }


    }
    private void Start()
    {
        LevelTextControl();
       
    }
    public void UpdateSavedInformation()
    {
        SaveData savedData = SaveSystem.LoadGame();
        if (savedData != null)
        {
            PlayerPosText.text = "Saved Pos: " + savedData.position;
            PlayerHealthText.text = "Saved Health: " + savedData.health;
            PlayerGoldText.text = "Saved Gold: " + savedData.gold;
            StoryProgressText.text = "Saved Story: " + savedData.storyProgress;
            CheckPointIdText.text = "Checkpoint ID: " + savedData.checkPointId;

            OpenCheckPointButton();
        }
        else
        {
            PlayerPosText.text = "Saved Pos: N/A";
            PlayerHealthText.text = "Saved Health: N/A";
            PlayerGoldText.text = "Saved Gold: N/A";
            StoryProgressText.text = "Saved Story: N/A";
            CheckPointIdText.text = "Checkpoint ID: N/A";
        }
    }

    public void UpdateUnsavedInformation()
    {

        UnSavedPlayerPosText.text = "Current Pos: " + PlayerData.instance.pos;
        UnSavedPlayerHealthText.text = "Current Health: " + PlayerData.instance.health;
        UnSavedPlayerGoldText.text = "Current Gold: " + PlayerData.instance.gold;
        UnSavedStoryProgressText.text = "Current Story: " + PlayerData.instance.storyProgress;
        UnSavedCheckPointIdText.text = "Checkpoint ID: " + PlayerData.instance.checkPointId;

    }

    public void SaveAllButtonClick()
    {
        SaveSystem.SaveGame(PlayerData.instance);
        UpdateSavedInformation();
    }

    public void OpenCheckPointButton()
    {
        for (int i = 0; i < PlayerData.instance.activeCheckpoints.Count; i++)
        {
            checkPointButtons[i].gameObject.SetActive(true);
        }
    }

    public void CheckPointButtonClick(int checkPointId, int sceneId)
    {

        int currentSceneID = SceneManager.GetActiveScene().buildIndex;

        if (sceneId == currentSceneID)
        {
            TeleportToCheckpoint(checkPointId);
        }
        else
        {

            storedCheckPointId = checkPointId;
            SceneManager.sceneLoaded += OnSceneLoaded;
            SceneManager.LoadScene(sceneId);
        }
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

        LevelTextControl();

        TeleportToCheckpoint(storedCheckPointId);


        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    public void TeleportToCheckpoint(int index)
    {
        if (index >= 0 && index - 1 < PlayerData.instance.activeCheckpoints.Count)
        {

            FindObjectOfType<PlayerMove>().transform.position = new Vector3(PlayerData.instance.activeCheckpoints[index - 1].x, 0.45f);
        }
    }


    public void NextLevel()
    {
        SceneManager.sceneLoaded += OnNextScene;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    void OnNextScene(Scene scene, LoadSceneMode mode)
    {
        LevelTextControl();
    }
    public void LevelTextControl()
    {
        PlayerPrefs.SetInt("level", SceneManager.GetActiveScene().buildIndex);

        LevelText.text = "Level:" + PlayerPrefs.GetInt("level");
    }
}
