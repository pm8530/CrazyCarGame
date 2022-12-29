using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public static MainMenuController instance;

    public GameObject playButton;
    public GameObject optionButton;
    public GameObject exitButton;

    public GameObject backButton;
    public GameObject optionMenuButton;

    


    // OPTION MENU GAMEPLAY

    public GameObject gameoptionButton;
    public GameObject resumebutton;
    
    public GameObject settingPanel;
    public GameObject gameOverPanel;

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void PlayButton()
    {
        SceneManager.LoadScene("GamePlay");
        Time.timeScale = 1f;
    }


    public void ExitButton()
    {
        Application.Quit();

        Debug.Log("Quit");
    }


    public void OptionButton()
    {
        playButton.SetActive(false);
        optionButton.SetActive(false);
        exitButton.SetActive(false);

        optionMenuButton.SetActive(true);
        backButton.SetActive(true);



    }


    public void  Backbutton()
    {
        backButton.SetActive(false);
        optionMenuButton.SetActive(false);


        playButton.SetActive(true);
        optionButton.SetActive(true);
        exitButton.SetActive(true);
    }

    public void Settingbutton()
    {

    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void  GameOptionButton()
    {
        settingPanel.SetActive(true);
        Time.timeScale = 0f;

    }

    public void GameResumeButton()
    {
        settingPanel.SetActive(false);
        Time.timeScale = 1f;
    }


    public void GameBackButton()
    {
        settingPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GameRestartButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

}
