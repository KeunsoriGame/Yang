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
        }

        else
        {
            Time.timeScale = 0;
            GameObject.Find("Canvas").transform.GetChild(5).gameObject.SetActive(true);
        }

    }
}
