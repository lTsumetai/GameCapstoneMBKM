using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int levelClear;

    public GameData(LevelManager lManager)
    {
        levelClear = lManager.clearLevel;
        
    }
}