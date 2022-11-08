using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField] // private 함수를 inspector에서 관리 가능하게 함
    GameObject A, B, C, D, E, F;

    Vector2 creatPoint;
    int[] SpawnObj = new int[6];

    void Update()
    {
        SpawnPlay();
    }

    void Spawn()
    {
        creatPoint = transform.position;
        creatPoint.x = 350f;
        creatPoint.y = 700f;
        transform.position = creatPoint;

        for (int i = 0; i < 6; i++)
        {
            SpawnObj[i] = Random.Range(1, 7);

            if (SpawnObj[i] == 1)
            {
                Instantiate(A, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Prefab").transform);
                creatPoint.x += 250f;
            }

            else if (SpawnObj[i] == 2)
            {
                Instantiate(B, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Prefab").transform);
                creatPoint.x += 250f;
            }

            else if (SpawnObj[i] == 3)
            {
                Instantiate(C, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Prefab").transform);
                creatPoint.x += 250f;
            }

            else if (SpawnObj[i] == 4)
            {
                Instantiate(D, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Prefab").transform);
                creatPoint.x += 250f;
            }

            else if (SpawnObj[i] == 5)
            {
                Instantiate(E, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Prefab").transform);
                creatPoint.x += 250f;
            }

            else
            {
                Instantiate(F, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Prefab").transform);
                creatPoint.x += 250f;
            }
        }
    }
    void SpawnPlay()
    {
        if (!(GameObject.FindWithTag("A") || GameObject.FindWithTag("B") || GameObject.FindWithTag("C") || GameObject.FindWithTag("D") || GameObject.FindWithTag("E") || GameObject.FindWithTag("F")))
        {
            Spawn();
        }
    }
}