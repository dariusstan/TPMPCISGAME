using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_control : MonoBehaviour
{
    public static Music_control instance;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
