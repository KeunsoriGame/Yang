using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public float speed = 100f;

    private bool gameOver;

    private void Start()
    {
        gameOver = GameObject.Find("GameManager").GetComponent<GameManager3>().isGameover;
    }
    private void Update()
    {
        if (!gameOver)
        {
            transform.Translate(5f * Vector3.left * speed * Time.deltaTime);
        }


    }
}