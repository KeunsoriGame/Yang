using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeController : MonoBehaviour
{
    public Slider bgmSlider;
    public Slider effectSlider;

    public void DeleteData()
    {
        // 레벨 초기화
        PlayerPrefs.SetInt("level", 1);

        //스탯 초기화
        PlayerPrefs.SetInt("dEx", 15);
        PlayerPrefs.SetInt("dConf", 15);

        PlayerPrefs.SetInt("gEx", 15);
        PlayerPrefs.SetInt("gConf", 15);

        PlayerPrefs.SetInt("bEx", 15);
        PlayerPrefs.SetInt("bConf", 15);

        PlayerPrefs.SetInt("kEx", 15);
        PlayerPrefs.SetInt("kConf", 15);

        PlayerPrefs.SetInt("vEx", 15);
        PlayerPrefs.SetInt("vConf", 15);


        GameObject.Find("Stat").GetComponent<Stat>().SetData();
    }


    public void SetBGM()
    {
        GameObject.Find("SoundManager").GetComponent<SoundControl>().SetBGMVolume(bgmSlider.value);
    }

    public void SetEffectSound()
    {
        GameObject.Find("SoundManager").GetComponent<SoundControl>().SetBGMVolume(effectSlider.value);
    }
}
