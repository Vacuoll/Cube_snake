using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    public Button easyButton;
    public Button mediumButton;
    public Button hardButton;
    private int difficulty = 0;
    
    public void Easy()
    {
        easyButton.interactable = false;
        mediumButton.interactable = true;
        hardButton.interactable = true;
        difficulty = 0;
        PlayerPrefs.SetInt("Diff", difficulty);
    }

    public void Medium()
    {
        easyButton.interactable = true;
        mediumButton.interactable = false;
        hardButton.interactable = true;
        difficulty = 1;
        PlayerPrefs.SetInt("Diff", difficulty);
    }

    public void Hard()
    {
        easyButton.interactable = true;
        mediumButton.interactable = true;
        hardButton.interactable = false;
        difficulty = 2;
        PlayerPrefs.SetInt("Diff", difficulty);
    }

    private void Start()
    {
        difficulty = PlayerPrefs.GetInt("Diff");
        if (difficulty == 0)
        {
            Easy();
        }
        else if (difficulty == 1)
        {
            Medium();
        }
        else if (difficulty == 2)
        {
            Hard();
        }
    }
}
