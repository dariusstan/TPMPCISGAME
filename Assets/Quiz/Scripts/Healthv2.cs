 /// <summary>
    /// Method called to check the answer is correct or not
    /// </summary>
    /// <param name="selectedOption">answer string</param>
    /// <returns></returns>

//     public bool Answer(string selectedOption)
//     {
//         //set default to false
//         bool correct = false;
//         //if selected answer is similar to the correctAns
//         if (selectedQuetion.correctAns == selectedOption) //not equal !=
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
//     }

// public string correctAns;           //correct option



// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// using UnityEngine.UI;

// public class Healthv2 : MonoBehaviour
// {
//     #pragma warning disable 649
//         //ref to the QuizGameUI script
//         [SerializeField] private QuizGameUI quizGameUI;
//         [SerializeField] private Response response;
//         [SerializeField] private List<Image> lifeImageList;
//     #pragma warning restore 649

// 	private int lifesRemaining;

//     /// <summary>
//     /// Method called to check the answer is correct or not
//     /// </summary>
//     /// <param name="selectedOption">answer string</param>
//     /// <returns></returns>


//     public bool Answer(string selectedOption)
//     {
//         bool correct = false;
//         if (response.correctAns != selectedOption)
//         {
//             lifesRemaining--;
//             quizGameUI.ReduceLife(lifesRemaining);

//             if (lifesRemaining == 0)
//             {
//                 quizGameUI.GameOverPanel.SetActive(true);
                
//             }

//         }
//         return correct;

//     }
//     public string correctAns;  
// }


// public class Healthv2 : MonoBehaviour
// {
// #pragma warning disable 649
//     //ref to the QuizGameUI script
//     [SerializeField] private QuizGameUI ForHealth;
//     //ref to the scriptableobject file
//     [SerializeField] private List<Response> responseList;
// #pragma warning restore 649

//     private int gameScore;
//     private int lifesRemaining;
//     private Response responseList;

   
//     public List<Response> QuizData { get => responseList; }
// }
