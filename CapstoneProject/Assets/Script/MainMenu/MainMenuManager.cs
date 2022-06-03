using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    [Header("Main Menu Panel List")]
    public GameObject MainPanel;
    public GameObject OptionPanel;
    public GameObject CreditsPanel;


    // Start is called before the first frame update
    void Start()
    {
        MainPanel.SetActive(true);
        OptionPanel.SetActive(false);
        CreditsPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OptionButton()
    {
        OptionPanel.SetActive(true);
    }

        public void CreditsButton()
    {
        CreditsPanel.SetActive(true);
    }


    public void BackButton()
    {
        OptionPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        MainPanel.SetActive(true);
    }


   // public void StartBtn()
    //{
      //  SceneManager.LoadScene("2. Gameplay");
    //}

    public void ExitGame()
    {
        Application.Quit();
    }
}
