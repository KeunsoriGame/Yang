using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardStat : MonoBehaviour
{
    public Slider exSlider;
    public Slider confiSlider;
    public Text exT;
    public Text confT;

    public void Start()
    {
        exSlider.value = GameObject.Find("mainControl").GetComponent<Stat>().k_ex;
        confiSlider.value = GameObject.Find("mainControl").GetComponent<Stat>().k_conf;
        exT.text = exSlider.value + " / 100";
        confT.text = confiSlider.value + " / 100";
    }

    public void KeyboardS()
    {
        Stat.Instance.session[3] = 1;
    }
}
