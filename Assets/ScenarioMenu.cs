using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenarioMenu : MonoBehaviour {

    public void BackToMainMenu(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

    public void Scenario1(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 16);

    }

    public void Scenario2(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 19);

    }

    public void Scenario3(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 22);

    }

    public void Scenario4(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 25);

    }

    public void Scenario5(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 28);

    }
   
}
