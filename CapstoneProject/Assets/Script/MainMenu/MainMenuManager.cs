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
    public GameObject PlayGamePanel;
    public GameObject CustomModePanel;


    // Start is called before the first frame update
    void Start()
    {
        MainPanel.SetActive(true);
        OptionPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        PlayGamePanel.SetActive(false);
        CustomModePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGameButton()
    {
        PlayGamePanel.SetActive(true);
    }

    public void CustomModeButton()
    {
        CustomModePanel.SetActive(true);
        PlayGamePanel.SetActive(false);
        MainPanel.SetActive(false);
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
        PlayGamePanel.SetActive(false);
        CustomModePanel.SetActive(false);
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
