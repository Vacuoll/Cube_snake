using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public static LevelController instance = null;
    int sceneIndex;
    int levelComplete;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
        PlayerPrefs.Save();
    }

    public void IsEndGame()
    {
        if (levelComplete < sceneIndex)
        {
            PlayerPrefs.SetInt("LevelComplete", sceneIndex + 1);
            PlayerPrefs.Save();
        }

            NextLevel();
    }
    

  void NextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

    void LoadMainMenu()
    {
        SceneManager.LoadScene("Levels");
    }
}
