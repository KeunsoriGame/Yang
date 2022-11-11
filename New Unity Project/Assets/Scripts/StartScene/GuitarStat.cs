using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuitarStat : MonoBehaviour
{
    public Slider exSlider;
    public Slider confiSlider;

    public void Start()
    {
        exSlider.value = GameObject.Find("mainControl").GetComponent<Stat>().g_ex;
        confiSlider.value = GameObject.Find("mainControl").GetComponent<Stat>().g_conf;
    }

    public void GuitarS()
    {
        Stat.Instance.session[1] = 1;
    }
}
