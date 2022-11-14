using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VocalStat : MonoBehaviour
{
    public Slider exSlider;
    public Slider confiSlider;

    public void Start()
    {
        exSlider.value = GameObject.Find("mainControl").GetComponent<Stat>().v_ex;
        confiSlider.value = GameObject.Find("mainControl").GetComponent<Stat>().v_conf;
    }

    public void VocalS()
    {
        Stat.Instance.session[4] = 1;
    }
}
