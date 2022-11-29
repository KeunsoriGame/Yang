using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSliderController : MonoBehaviour
{
    public Slider TimeSld;
    public GameObject stageClear;
    public GameObject mission;
    public Button button;

    void Start()
    {
        MissionPopup();
        button.onClick.AddListener(MissionButton);

        TimeSld = GetComponent<Slider>();
        TimeSld.value = 0;
    }

    void Update()
    {
        if (TimeSld.value < 60)
        {
            TimeSld.value += Time.deltaTime;
        }

        else
        {
            //½ºÅÈ »ó½Â
            int i = 0;
            for (i = 0; i < 5; i++)
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
                    Stat.Instance.d_ex += 5;
                    Stat.Instance.d_conf += 5;
                    PlayerPrefs.SetInt("dEx", Stat.Instance.d_ex);
                    PlayerPrefs.SetInt("dConf", Stat.Instance.d_conf);
                    break;
                case 1:
                    Stat.Instance.g_ex += 5;
                    Stat.Instance.g_conf += 5;
                    PlayerPrefs.SetInt("gEx", Stat.Instance.g_ex);
                    PlayerPrefs.SetInt("gConf", Stat.Instance.g_conf);
                    break;
                case 2:
                    Stat.Instance.b_ex += 5;
                    Stat.Instance.b_conf += 5;
                    PlayerPrefs.SetInt("bEx", Stat.Instance.b_ex);
                    PlayerPrefs.SetInt("bConf", Stat.Instance.b_conf);
                    break;
                case 3:
                    Stat.Instance.k_ex += 5;
                    Stat.Instance.k_conf += 5;
                    PlayerPrefs.SetInt("kEx", Stat.Instance.k_ex);
                    PlayerPrefs.SetInt("kConf", Stat.Instance.k_conf);
                    break;
                case 4:
                    Stat.Instance.v_ex += 5;
                    Stat.Instance.v_conf += 5;
                    PlayerPrefs.SetInt("vEx", Stat.Instance.v_ex);
                    PlayerPrefs.SetInt("vConf", Stat.Instance.v_conf);
                    break;
                default:
                    break;
            }

            Time.timeScale = 0;
            TimeSld.gameObject.SetActive(false);
            stageClear.gameObject.SetActive(true);
            Debug.Log("Stage Clear");
            
        }

    }

    void MissionPopup()
    {
        Time.timeScale = 0f;
        mission.gameObject.SetActive(true);
    }

    void MissionButton()
    {
        mission.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}
