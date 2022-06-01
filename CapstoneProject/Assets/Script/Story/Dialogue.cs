using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue : MonoBehaviour
{
   
    public string nama;
    public string sceneName;
    public GameObject character;

    [TextArea(3, 10)]
    public string[] sentences;
    
}
