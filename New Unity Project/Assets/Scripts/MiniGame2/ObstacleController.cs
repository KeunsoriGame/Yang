using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    void Update()
    {
        switch (Stat.Instance.level)
        {
            case 1:
            case 2:
                transform.Translate(0, -2.5f, 0);
                break;
            case 3:
                transform.Translate(0, -3.0f, 0);
                break;
            case 4:
            case 5:
                transform.Translate(0, -3.5f, 0);
                break;
            default:
                break;
        }

        if (transform.position.y < -1.0f)
        {
            Destroy(gameObject);
        }

    }
}