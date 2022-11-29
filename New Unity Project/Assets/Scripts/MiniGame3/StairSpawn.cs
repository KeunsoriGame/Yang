using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairSpawn : MonoBehaviour
{
    GameObject rightStairPrefab;
    GameObject leftStairPrefab;

    void Start()
    {
        rightStairPrefab = Resources.Load("MiniGame3/RightRotateStair") as GameObject;
        leftStairPrefab = Resources.Load("MiniGame3/LeftRotateStair") as GameObject;
        GameObject rightStair = MonoBehaviour.Instantiate(rightStairPrefab);
        GameObject leftStair = MonoBehaviour.Instantiate(leftStairPrefab);

        Vector3 rpos = new Vector3(6.0f, 5.52f, 0);
        Vector3 lpos = new Vector3(6.0f, 5.48f, 0);
        rightStair.transform.position = rpos;
        leftStair.transform.position = lpos;
    }


    void Update()
    {
        
    }
}
