using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGamePage : MonoBehaviour {

    public void PlayingPage(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void FinishGame(){

        SceneManager.LoadScene(0);

    }
    
}
