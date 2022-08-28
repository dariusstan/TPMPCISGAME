using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenarioMenu : MonoBehaviour {

    public void BackToMainMenu(){

        SceneManager.LoadScene(0);

    }

    public void Scenario1(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 22);

    }

    public void Scenario2(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 26);

    }

    public void Scenario3(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 30);

    }

    public void Scenario4(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 34);

    }

    public void Scenario5(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 38);

    }
   
}
