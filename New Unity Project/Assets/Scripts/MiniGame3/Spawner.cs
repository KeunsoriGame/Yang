using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject A, B, C, D, E, F, G, H, cardCover;
    Vector2 creatPoint;
    int[] SpawnObj = new int[16];  // 카드 리스트

    void Spawn()
    {
        creatPoint = transform.position;
        creatPoint.x = 600f;
        creatPoint.y = 900f;
        transform.position = creatPoint;
        int count = 0;

        for(int i = 0; i < 16; i++)
        {
            SpawnObj[i] = i / 2 + 1;
        }

        // 카드 리스트 섞기
        for(int i = 0; i < 30; i++)
        {
            int n1 = Random.Range(0, 16);
            int n2 = Random.Range(0, 16);

            int temp = SpawnObj[n1];
            SpawnObj[n1] = SpawnObj[n2];
            SpawnObj[n2] = temp;
        }

        for (int i = 0; i < 16; i++)
        {
            if (SpawnObj[i] == 1)
            {
                Instantiate(A, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));
                Instantiate(cardCover, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));

                if (count == 3) // 줄바꿈
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
                //Instantiate(cardCover, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));

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
                //Instantiate(cardCover, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));

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
                //Instantiate(cardCover, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));

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

            else if (SpawnObj[i] == 5)
            {
                Instantiate(E, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));
                //Instantiate(cardCover, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));

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

            else if (SpawnObj[i] == 6)
            {
                Instantiate(F, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));
                //Instantiate(cardCover, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));

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

            else if (SpawnObj[i] == 7)
            {
                Instantiate(G, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));
                //Instantiate(cardCover, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));

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
                Instantiate(H, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));
                //Instantiate(cardCover, creatPoint, Quaternion.identity, GameObject.Find("Canvas/Card").transform.GetChild(i));

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

 
    void Start()
    {
        Spawn();
        for (int i = 0; i < 16; i++)
            Debug.Log(SpawnObj[i]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
