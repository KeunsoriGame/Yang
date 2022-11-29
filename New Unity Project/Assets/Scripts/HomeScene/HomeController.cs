using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeController : MonoBehaviour
{
    /*
    private static HomeController instance = null;

    public static HomeController Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }

    void Awake()
    {
        if (null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    */

    void Update()
    {
        
    }

    public void DeleteData()
    {
        // 레벨 초기화
        PlayerPrefs.SetInt("level", 1);

        //스탯 초기화
        PlayerPrefs.SetInt("dEx", 15);
        PlayerPrefs.SetInt("dConf", 15);

        PlayerPrefs.SetInt("gEx", 15);
        PlayerPrefs.SetInt("gConf", 15);

        PlayerPrefs.SetInt("bEx", 15);
        PlayerPrefs.SetInt("bConf", 15);

        PlayerPrefs.SetInt("kEx", 15);
        PlayerPrefs.SetInt("kConf", 15);

        PlayerPrefs.SetInt("vEx", 15);
        PlayerPrefs.SetInt("vConf", 15);


        GameObject.Find("Stat").GetComponent<Stat>().SetData();
    }
}
