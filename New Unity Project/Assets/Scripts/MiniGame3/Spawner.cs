using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject A, B, C, D, E, cardCover;
    Vector2 creatPoint;
    int[] SpawnObj = new int[16];

    void Spawn()
    {
        creatPoint = transform.position;
        creatPoint.x = 600f;
        creatPoint.y = 900f;
        transform.position = creatPoint;
        int count = 0;

        for (int i = 0; i < 16; i++)
        {
            SpawnObj[i] = Random.Range(1, 7);

            if (SpawnObj[i] == 1)
            {
                Instantiate(A, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));
                Instantiate(cardCover, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));
                if (count == 3)
                {
                    creatPoint.y -= 250f;
                    creatPoint.x -= 750f;
                    count = 0;
                }

                else
                {
                    creatPoint.x += 250f;
                    count++;
                }

            }

            else if (SpawnObj[i] == 2)
            {
                Instantiate(B, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));
                Instantiate(cardCover, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));
                if (count == 3)
                {
                    creatPoint.y -= 250f;
                    creatPoint.x -= 750f;
                    count = 0;
                }

                else
                {
                    creatPoint.x += 250f;
                    count++;
                }
            }

            else if (SpawnObj[i] == 3)
            {
                Instantiate(C, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));
                Instantiate(cardCover, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));
                if (count == 3)
                {
                    creatPoint.y -= 250f;
                    creatPoint.x -= 750f;
                    count = 0;
                }

                else
                {
                    creatPoint.x += 250f;
                    count++;
                }
            }

            else if (SpawnObj[i] == 4)
            {
                Instantiate(D, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));
                Instantiate(cardCover, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));
                if (count == 3)
                {
                    creatPoint.y -= 250f;
                    creatPoint.x -= 750f;
                    count = 0;
                }

                else
                {
                    creatPoint.x += 250f;
                    count++;
                }
            }

            else
            {
                Instantiate(E, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));
                Instantiate(cardCover, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));
                if (count == 3)
                {
                    creatPoint.y -= 250f;
                    creatPoint.x -= 750f;
                    count = 0;
                }

                else
                {
                    creatPoint.x += 250f;
                    count++;
                }
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
