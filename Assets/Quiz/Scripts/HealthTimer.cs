// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.SceneManagement;

// public class HealthTimer : MonoBehaviour
// {
//     //all the functions that i would need (QuizGameUI)
//     //Take notes of the needed 
//     public void ReduceLife(int remainingLife)
//     {
//         lifeImageList[remainingLife].color = Color.red;
//     }

//     /// <summary>
//     /// IEnumerator to repeate the audio after some time
//     /// </summary>
//     /// <returns></returns>
// -------------------------------------------------------------------------------------
//     //Method called by Category Button
//     private void CategoryBtn(int index, string category)
//     {
//         quizManager.StartGame(index, category); //start the game
//         mainMenu.SetActive(false);              //deactivate mainMenu
//         gamePanel.SetActive(true);              //activate game panel
//     }
// ------------------------------------------------------------------------------------------

//     public void RestryButton()
//     {
//         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
//     }
// ==========================================================================================
//     //all the functions needed for QuizManager
//      public void StartGame(int categoryIndex, string category)
//     {
//         currentCategory = category;
//         correctAnswerCount = 0;
//         gameScore = 0;
//         lifesRemaining = 3;
//         currentTime = timeInSeconds;
//         //set the questions data
//         questions = new List<Question>();
//         dataScriptable = quizDataList[categoryIndex];
//         questions.AddRange(dataScriptable.questions);
//         //select the question
//         SelectQuestion();
//         gameStatus = GameStatus.PLAYING;
//     }
// ----------------------------------------------------------------------------------------------
// private void Update()
//     {
//         if (gameStatus == GameStatus.PLAYING)
//         {
//             currentTime -= Time.deltaTime;
//             SetTime(currentTime);
//         }
//     }
// -----------------------------------------------------------------------------------------------
// void SetTime(float value)
//     {
//         TimeSpan time = TimeSpan.FromSeconds(currentTime);                       //set the time value
//         quizGameUI.TimerText.text = time.ToString("mm':'ss");   //convert time to Time format

//         if (currentTime <= 0)
//         {
//             //Game Over
//             GameEnd();
//         }
//     }
// ------------------------------------------------------------------------------------------------
// /// <summary>
//     /// Method called to check the answer is correct or not
//     /// </summary>
//     /// <param name="selectedOption">answer string</param>
//     /// <returns></returns>
//     public bool Answer(string selectedOption)
//     {
//         //set default to false
//         bool correct = false;
//         //if selected answer is similar to the correctAns
//         if (selectedQuetion.correctAns == selectedOption)
//         {
//             //Yes, Ans is correct
//             correctAnswerCount++;
//             correct = true;
//             gameScore += 50;
//             quizGameUI.ScoreText.text = "Score:" + gameScore;
//         }
//         else
//         {
//             //No, Ans is wrong
//             //Reduce Life
//             lifesRemaining--;
//             quizGameUI.ReduceLife(lifesRemaining);

//             if (lifesRemaining == 0)
//             {
//                 GameEnd();
//             }
//         }

//         if (gameStatus == GameStatus.PLAYING)
//         {
//             if (questions.Count > 0)
//             {
//                 //call SelectQuestion method again after 1s
//                 Invoke("SelectQuestion", 0.4f);
//             }
//             else
//             {
//                 GameEnd();
//             }
//         }
//         //return the value of correct bool
//         return correct;
//     }

//     private void GameEnd()
//     {
//         gameStatus = GameStatus.NEXT;
//         quizGameUI.GameOverPanel.SetActive(true);

//         //fi you want to save only the highest score then compare the current score with saved score and if more save the new score
//         //eg:- if correctAnswerCount > PlayerPrefs.GetInt(currentCategory) then call below line

//         //Save the score
//         PlayerPrefs.SetInt(currentCategory, correctAnswerCount); //save the score for this category
//     }
// -----------------------------------------------------------------------------------------
// }
