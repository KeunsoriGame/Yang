using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    int statSum = 0;
    public Slider loading;

    public GameObject load;
    public GameObject levelup;
    public GameObject levelupfail;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void LevelManager()  // 합주하기 버튼 클릭 시
    {
        load.SetActive(true);
        Invoke("LevelUP", 3f);
    }

    void LevelUP()
    {
        load.SetActive(false);
        levelup.SetActive(true);
    }

    void LevelUPFail()
    {
        load.SetActive(false);
    }

    

}
