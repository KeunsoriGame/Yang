using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    void Update()
    {
        transform.Translate(0, -1.5f, 0);  // 떨어지는 속도

        if (transform.position.y < -1.0f)  // 화면 밖으로 나가면 제거
        {
            Destroy(gameObject);
        }

    }
}