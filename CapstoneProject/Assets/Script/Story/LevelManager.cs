using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Button[] btnLevels;

    [Range(1, 9)]
    public int clearLevel;
    
    void Start()
    {
        
    }

    void Update()
    {
        checkSave();
    }

    public void checkSave()
    {
        for (int i = 0; i < clearLevel; i++)
        {
            btnLevels[i].interactable = true;
        }

        for (int i = 8; i >= clearLevel; i--)
        {
            btnLevels[i].interactable = false;
        }
    }

    //==============SAVE & LOAD DATA GAME===============================
    public void saveGame()
    {
        SaveSystem.SaveGame(this);
    }

    public void loadGame()
    {
        GameData data = SaveSystem.LoadGame();

        clearLevel = data.levelClear;
    }
}
