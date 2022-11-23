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
        TimeSld.maxValue = 16;
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
