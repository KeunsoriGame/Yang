using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrumStat : MonoBehaviour
{
    public Slider exSlider;
    public Slider confiSlider;
    public Text exT;
    public Text confT;

    public void Start()
    {
        exSlider.value = GameObject.Find("Stat").GetComponent<Stat>().d_ex;
        confiSlider.value = GameObject.Find("Stat").GetComponent<Stat>().d_conf;

        exT.text = exSlider.value + " / 100";
        confT.text = confiSlider.value + " / 100";
    }

    public void DrumS()
    {
        Stat.Instance.session[0] = 1;
    }
}
