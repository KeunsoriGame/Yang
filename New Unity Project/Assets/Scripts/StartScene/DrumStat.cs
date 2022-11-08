using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrumStat : MonoBehaviour
{
    public Slider exSlider;
    public Slider confiSlider;

    public void Start()
    {
        exSlider.value = GameObject.Find("mainControl").GetComponent<Stat>().d_ex;
        confiSlider.value = GameObject.Find("mainControl").GetComponent<Stat>().d_conf;
    }

    public void exUP()
    {
        exSlider.value = 47;
    }

    public void confiUP()
    {
        confiSlider.value = 89;
    }
}
