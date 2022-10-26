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

        }

    }
}
