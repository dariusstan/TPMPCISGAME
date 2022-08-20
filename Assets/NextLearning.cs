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

        SceneManager.LoadScene(23);

    }

    public void OpenLink2(){

        SceneManager.LoadScene(24);

    }

    public void OpenLink3(){

        SceneManager.LoadScene(25);

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
