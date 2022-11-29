using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuitarStat : MonoBehaviour
{
    public Slider exSlider;
    public Slider confiSlider;
    public Text exT;
    public Text confT;

    public void Start()
    {
        exSlider.value = GameObject.Find("Stat").GetComponent<Stat>().g_ex;
        confiSlider.value = GameObject.Find("Stat").GetComponent<Stat>().g_conf;

        exT.text = exSlider.value + " / 100";
        confT.text = confiSlider.value + " / 100";
    }

    public void GuitarS()
    {
        Stat.Instance.session[1] = 1;
    }
}
