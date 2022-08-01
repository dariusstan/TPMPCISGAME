using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContentsPage : MonoBehaviour
{
    public void StartPage(){

        SceneManager.LoadScene(0);

    }

    public void PreviousPage(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

    public void NextContentPage(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void SimpleTerms(){

        SceneManager.LoadScene(6);

    }

    public void SOP(){

        SceneManager.LoadScene(10);

    }

    public void PCLAPTOP(){

        SceneManager.LoadScene(12);

    }

    public void HDD(){

        SceneManager.LoadScene(13);

    }

    public void SMARTDEVICES(){

        SceneManager.LoadScene(14);

    }

    public void CAMERAS(){

        SceneManager.LoadScene(16);

    }

    public void CONSOLES(){

        SceneManager.LoadScene(17);

    }

    public void CCTV(){

        SceneManager.LoadScene(18);

    }

    public void INFO1(){

        SceneManager.LoadScene(19);

    }

    public void INFO2(){

        SceneManager.LoadScene(20);

    }

    public void FirstResponder(){

        SceneManager.LoadScene(21);

    }


}
