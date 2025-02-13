using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Preload : MonoBehaviour
{
    public Sprite logo;
    public float waitTime;
    public string levelNumber_Haskey;
    public int minimumRandomLevelNumber;

    private void Start()
    {

        Invoke("WaitStartLoadGame", waitTime);

    }

    private void WaitStartLoadGame()
    {
        if (!PlayerPrefs.HasKey(levelNumber_Haskey))
        {
            PlayerPrefs.SetInt(levelNumber_Haskey, 1);
            SceneManager.LoadScene(1);
        }
        else
        {
            int level = PlayerPrefs.GetInt(levelNumber_Haskey);

            SceneManager.LoadScene(level);

        }

      //  UIManager.instance.mainPanel.SetActive(true);


    }
}
