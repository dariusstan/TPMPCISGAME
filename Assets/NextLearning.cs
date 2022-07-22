using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLearning : MonoBehaviour {

    public void NextLearningPage(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void BackToStart(){

        SceneManager.LoadScene(0);

    }
    
}
