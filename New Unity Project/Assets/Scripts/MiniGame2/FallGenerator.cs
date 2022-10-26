using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallGenerator : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject[] fallPrefeb;  // ÇÁ¸®ÆÕ ¸®½ºÆ®
    float span = 0.5f;  // ÁÖ±â
    float delta = 0;

    void Start()
    {

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
        int px;  // ·£´ý xÁÂÇ¥
        GameObject newObs;

        switch (random) // 60% È®·ü·Î Àå¾Ö¹° , 40% È®·ü·Î ¾ÆÀÌÅÛ
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
    }
}
