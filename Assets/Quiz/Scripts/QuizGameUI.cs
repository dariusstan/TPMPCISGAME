using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizGameUI : MonoBehaviour
{
#pragma warning disable 649
    [SerializeField] private Text timerText;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject summaryMenu;
#pragma warning restore 649


    public Text TimerText { get => timerText; }                                   //getter
    public GameObject GameOverPanel { get => gameOverPanel; }                     //getter
    public GameObject PauseMenu { get => pauseMenu; }                             //getter
    public GameObject SummaryMenu { get => summaryMenu; }

    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );
        Time.timeScale = 1f;
    }

    public void OtherSceneButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 22);
    }

    public void mMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 38);
    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void YesBtn()
    {
        SceneManager.LoadScene(34);
    }

    public void NoBtn()
    {
        SummaryMenu.SetActive(false);
        Time.timeScale = 1f;
    }

}
    
