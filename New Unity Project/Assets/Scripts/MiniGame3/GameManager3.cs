using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager3 : MonoBehaviour
{
    public bool isGameover = false;
    public Text scoreText;
    public GameObject gameover;

    private int score = 0;


    public void AddScore(int newScore)
    {
        if (!isGameover)
        {
            score += newScore;
            scoreText.text = "Score : " + score;
        }
    }

    public void PlayerDead()
    {
        isGameover = true;
        gameover.SetActive(true);
    }
}
