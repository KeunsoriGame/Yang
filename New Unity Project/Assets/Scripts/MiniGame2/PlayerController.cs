using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject gameover;

    void Start()
    {

    }

    void Update()
    {


        // 카메라 영역 밖 제한

    }

    public void LBottonDown()
    {
        transform.Translate(-50, 0, 0);
    }

    public void RBottonDown()
    {
        transform.Translate(50, 0, 0);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            other.gameObject.SetActive(false);
            gameover.gameObject.SetActive(true);
            Time.timeScale = 0;
            Debug.Log("Game Over");

        }

        else if (other.gameObject.tag == "item")
        {
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
    }
}

