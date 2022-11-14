using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardStat : MonoBehaviour
{
    public Slider exSlider;
    public Slider confiSlider;

    public void Start()
    {
        exSlider.value = GameObject.Find("mainControl").GetComponent<Stat>().k_ex;
        confiSlider.value = GameObject.Find("mainControl").GetComponent<Stat>().k_conf;
    }

    public void KeyboardS()
    {
        Stat.Instance.session[3] = 1;
    }
}
