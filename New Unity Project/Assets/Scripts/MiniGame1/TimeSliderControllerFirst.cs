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
        }

    }
}
