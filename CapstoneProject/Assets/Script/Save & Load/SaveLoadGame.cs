using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveLoadGame : MonoBehaviour
{
    LevelManager lManager;
    public void saveGame(int level)
    {
        LevelManager.levelStage = level;
        SceneManager.LoadScene("StoryScene");
    }
    public void loadGame()
    {
        GameData data = SaveSystem.LoadGame();

        LevelManager.instance.clearLevel = data.levelClear;
    }
}
