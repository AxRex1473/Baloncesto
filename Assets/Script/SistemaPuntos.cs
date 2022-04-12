using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SistemaPuntos : MonoBehaviour
{
    private int currentScore;
    public TextMeshProUGUI scoreText;

    // Use this for initialization
    void Start()
    {
        currentScore = 0;

    }

    private void HandleScore()
    {

        scoreText.text = "Score: " + currentScore;
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Puntos")
        {

            currentScore ++;
            HandleScore();
        }
    }
}