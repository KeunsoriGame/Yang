using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallGenerator : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject[] fallPrefeb;  // ������ ����Ʈ
    float span;  // �ֱ�
    float delta = 0;

    void Start()
    {
        // �������� �ֱ� ����
        switch (Stat.Instance.level)
        {
            case 1:
                span = 0.5f;
                break;
            case 2:
                span = 0.4f;
                break;
            case 3:
                span = 0.3f;
                break;
            case 4:
                span = 0.2f;
                break;
            case 5:
                span = 0.1f;
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0;

            RandomDraw();

        }

    }

    public void RandomDraw()
    {
        int random = Random.Range(0, 5);
        int px;  // ���� x��ǥ
        GameObject newObs;

        if (random <= 2)
        {
            px = Random.Range(-950, 950);
            newObs = Instantiate(fallPrefeb[0], new Vector3(px, 540, 0), transform.rotation) as GameObject;
            newObs.transform.SetParent(GameObject.FindGameObjectWithTag("Falling").transform, false);
        }

        else
        {
            px = Random.Range(-950, 950);
            newObs = Instantiate(fallPrefeb[1], new Vector3(px, 540, 0), transform.rotation) as GameObject;
            newObs.transform.SetParent(GameObject.FindGameObjectWithTag("Falling").transform, false);
        }

        /*
        switch (random) // 60% Ȯ���� ��ֹ� , 40% Ȯ���� ������
        {
            case 0:
            case 1:
            case 2:
                px = Random.Range(-950, 950);
                newObs = Instantiate(fallPrefeb[0], new Vector3(px, 540, 0), transform.rotation) as GameObject;
                newObs.transform.SetParent(GameObject.FindGameObjectWithTag("Falling").transform, false);
                break;
            case 3:
            case 4:
                px = Random.Range(-950, 950);
                newObs = Instantiate(fallPrefeb[1], new Vector3(px, 540, 0), transform.rotation) as GameObject;
                newObs.transform.SetParent(GameObject.FindGameObjectWithTag("Falling").transform, false);
                break;
            default:
                break;
        }
        */
    }
}
