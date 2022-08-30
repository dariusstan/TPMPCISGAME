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

        SceneManager.LoadScene(26);

    }

    public void OpenLink2(){

        SceneManager.LoadScene(27);
    }

    public void OpenLink3(){

        SceneManager.LoadScene(28);

    }

    public void Content1(){

        SceneManager.LoadScene(5);

    }

    public void Content2(){

        SceneManager.LoadScene(6);

    }

    public void Content3(){

        SceneManager.LoadScene(7);

    }

    public void Content4(){

        SceneManager.LoadScene(8);

    }

    public void VideoGoBack(){

        SceneManager.LoadScene(25);

    }
    

}
