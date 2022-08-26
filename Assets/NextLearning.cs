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

    public void GoBack(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

    public void OpenLink1(){

        Application.OpenURL("https://youtu.be/a-qHhpa8tqQ");

    }

    public void OpenLink2(){

        Application.OpenURL("https://youtu.be/Zg5ex8WZUao");

    }

    public void OpenLink3(){

        Application.OpenURL("https://youtu.be/ZUqzcQc_syE");

    }

    public void Content1(){

        SceneManager.LoadScene(2);

    }

    public void Content2(){

        SceneManager.LoadScene(3);

    }

    public void Content3(){

        SceneManager.LoadScene(4);

    }

    public void Content4(){

        SceneManager.LoadScene(5);

    }
    

}
