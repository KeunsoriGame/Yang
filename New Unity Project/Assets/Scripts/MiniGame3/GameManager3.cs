using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager3 : MonoBehaviour
{
    public bool isGameover = false;
    public Text scoreText;
    public GameObject gameover;
    public GameObject playB;

    private int score = 0;

    public void Start()
    {
        Time.timeScale = 0;
    }

    public void PlayStart()
    {
        Time.timeScale = 1;
    }

    public void AddScore(int newScore)
    {
        if (!isGameover)
        {
            score += newScore;
            scoreText.text = "S C O R E  :  " + score;
        }
    }

    public void PlayerDead()
    {
        isGameover = true;
        gameover.SetActive(true);
    }
}
