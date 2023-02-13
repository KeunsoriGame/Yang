using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSliderControllerFirst: MonoBehaviour
{
    public Slider TimeSld;

    void Start()
    {
        TimeSld = GetComponent<Slider>();
        TimeSld.value = 0;
        //TimeSld.maxValue = 16;

        switch (Stat.Instance.level)
        {
            case 1:
                TimeSld.maxValue = 20;
                break;
            case 2:
                TimeSld.maxValue = 16;
                break;
            case 3:
                TimeSld.maxValue = 14;
                break;
            case 4:
                TimeSld.maxValue = 12;
                break;
            case 5:
                TimeSld.maxValue = 10;
                break;
            default:
                break;
        }
    }

    void Update()
    {
        if (TimeSld.value < TimeSld.maxValue)
        {
            TimeSld.value += Time.deltaTime;
            //CoinScore.instance.AddCoin(10);
        }

        else
        {
            Time.timeScale = 0;
            GameObject.Find("Canvas").transform.GetChild(5).gameObject.SetActive(true);

            //스탯 하락
            int i = 0;
            for (i = 0; i < 5; i++)  // 어떤 세션인지 찾기
            {
                if (Stat.Instance.session[i] == 1)
                {
                    Stat.Instance.session[i] = 0;
                    break;
                }
            }

            switch (i)
            {
                case 0:
                    Stat.Instance.d_ex -= 3;
                    Stat.Instance.d_conf -= 3;
                    PlayerPrefs.SetInt("dEx", Stat.Instance.d_ex);
                    PlayerPrefs.SetInt("dConf", Stat.Instance.d_conf);
                    break;
                case 1:
                    Stat.Instance.g_ex -= 3;
                    Stat.Instance.g_conf -= 3;
                    PlayerPrefs.SetInt("gEx", Stat.Instance.g_ex);
                    PlayerPrefs.SetInt("gConf", Stat.Instance.g_conf);
                    break;
                case 2:
                    Stat.Instance.b_ex -= 3;
                    Stat.Instance.b_conf -= 3;
                    PlayerPrefs.SetInt("bEx", Stat.Instance.b_ex);
                    PlayerPrefs.SetInt("bConf", Stat.Instance.b_conf);
                    break;
                case 3:
                    Stat.Instance.k_ex -= 3;
                    Stat.Instance.k_conf -= 3;
                    PlayerPrefs.SetInt("kEx", Stat.Instance.k_ex);
                    PlayerPrefs.SetInt("kConf", Stat.Instance.k_conf);
                    break;
                case 4:
                    Stat.Instance.v_ex -= 3;
                    Stat.Instance.v_conf -= 3;
                    PlayerPrefs.SetInt("vEx", Stat.Instance.v_ex);
                    PlayerPrefs.SetInt("vConf", Stat.Instance.v_conf);
                    break;
                default:
                    break;
            }
            
        }

    }
}
