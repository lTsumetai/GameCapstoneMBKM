using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GantiScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PindahScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
