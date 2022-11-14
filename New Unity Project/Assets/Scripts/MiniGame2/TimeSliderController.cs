using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSliderController : MonoBehaviour
{
    public Slider TimeSld;
    public GameObject stageClear;

    void Start()
    {
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
            Time.timeScale = 0;
            TimeSld.gameObject.SetActive(false);
            stageClear.gameObject.SetActive(true);
            Debug.Log("Stage Clear");

            int i = 0;
            for(i=0; i<5; i++)
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
                    break;
                case 1:
                    Stat.Instance.g_ex += 5;
                    Stat.Instance.g_conf += 5;
                    break;
                case 2:
                    Stat.Instance.b_ex += 5;
                    Stat.Instance.b_conf += 5;
                    break;
                case 3:
                    Stat.Instance.k_ex += 5;
                    Stat.Instance.k_conf += 5;
                    break;
                case 4:
                    Stat.Instance.v_ex += 5;
                    Stat.Instance.v_conf += 5;
                    break;
                default:
                    break;
            }
        }

    }
}
