using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BassStat : MonoBehaviour
{
    public Slider exSlider;
    public Slider confiSlider;
    public Text exT;
    public Text confT;

    public void Start()
    {
        exSlider.value = GameObject.Find("mainControl").GetComponent<Stat>().b_ex;
        confiSlider.value = GameObject.Find("mainControl").GetComponent<Stat>().b_conf;
        exT.text = exSlider.value + " / 100";
        confT.text = confiSlider.value + " / 100";
    }

    public void BassS()
    {
        Stat.Instance.session[2] = 1;
    }
}
