using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This class stores the timer and the game over script,
//gameover script referrence QuizGameUI script
public class CountDownTimer : MonoBehaviour
{
    //float currentTime = 0f;
    //float startingTime = 180f;

    //[SerializeField] Text countdownText;
    [SerializeField] private QuizGameUI quizGameUI;
    int countDownStartValue = 5;
    public Text timerUI;

    // Start is called before the first frame update
    void Start()
    {
        //currentTime = startingTime;
        countDownTimer();
    }

    void countDownTimer()
    {
        if (countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerUI.text = "Timer: " + spanTime.Minutes + ":" + spanTime.Seconds;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }

        else
        {
            quizGameUI.GameOverPanel.SetActive(true);
            timerUI.text = "Game Ended!";
            Time.timeScale = 0f;
        }
    }


    // Update is called once per frame
    // void Update()
    // {
    //     currentTime -= 1 * Time.deltaTime;
    //     countdownText.text = currentTime.ToString ("Timer: 00");
    

    //     if (currentTime <= 0)
    //     {
    //         currentTime = 0;
    //     }
    // }
}
