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
        transform.Translate(0, -1.5f, 0);  // �������� �ӵ�

        if (transform.position.y < -1.0f)  // ȭ�� ������ ������ ����
        {
            Destroy(gameObject);
        }

    }
}