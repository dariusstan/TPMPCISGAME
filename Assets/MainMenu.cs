using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame(){

        SceneManager.LoadScene(4);

    }

    public void QuitGame(){

        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void TutorialGame(){

        SceneManager.LoadScene(1);

    }

    public void LoadMainMenu(){
        SceneManager.LoadScene(0);
    }
    public void loadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
