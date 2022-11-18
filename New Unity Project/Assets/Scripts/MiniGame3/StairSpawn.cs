using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairSpawn : MonoBehaviour
{
    GameObject stairPrefab;

    void Start()
    {
        stairPrefab = Resources.Load("MiniGame3/RightRotateStair") as GameObject;
        GameObject stair = MonoBehaviour.Instantiate(stairPrefab);

        Vector3 pos = new Vector3(6.0f, 5.52f, 0);
        stair.transform.position = pos;
    }


    void Update()
    {
        
    }
}
