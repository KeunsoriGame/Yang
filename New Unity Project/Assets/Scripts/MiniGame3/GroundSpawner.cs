using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundPrefab;
    public int count = 3;  // 생성할 발판 수

    public float timeBetSpawnMin = 1.25f;
    public float timeBetSpawnMax = 2.25f;
    private float timeBetSpawn;

    public float yMin = 3.5f;
    public float yMax = 5.5f;
    private float xPos = 1920f;

    private GameObject[] grounds;
    private int currentIndex = 0;  // 사용할 현재 발판 인덱스

    private Vector2 poolPosition = new Vector2(0, -25);  // 초기 발판 화면 밖에 숨김
    private float lastSpawnTime;  // 마지막 배치 시점


    void Start()
    {
        grounds = new GameObject[count];

        for(int i=0; i<count; i++)
        {
            grounds[i] = Instantiate(groundPrefab, poolPosition, Quaternion.identity) as GameObject;
            grounds[i].transform.SetParent(GameObject.FindGameObjectWithTag("Ground").transform, false);
        }

        lastSpawnTime = 0f;
        timeBetSpawn = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("GameManager").GetComponent<GameManager3>().isGameover){
            return;
        }

        if(Time.time >= lastSpawnTime + timeBetSpawn)
        {
            lastSpawnTime = Time.time;

            timeBetSpawn = Random.Range(timeBetSpawnMin, timeBetSpawnMax);

            float yPos = Random.Range(yMin, yMax);

            grounds[currentIndex].SetActive(false);
            grounds[currentIndex].SetActive(true);  // 비활성화했다가 바로 다시 활성화시킴 (OnEnable 함수 실행)

            grounds[currentIndex].transform.position = new Vector2(xPos, yPos*100);

            
            currentIndex++;

            if(currentIndex >= count)
            {
                currentIndex = 0;
            }

        }
    }
}
