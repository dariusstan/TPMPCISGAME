using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
   public Text scoreText;
   private int score;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ("Score: ") + score.ToString();

        if (Input.GetKeyDown(KeyCode.E))
        {
            score += 10;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            score -= 10;
        }
    }
}
