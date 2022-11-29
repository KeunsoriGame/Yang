using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundControl : MonoBehaviour
{
    public Slider bgmSlider;
    public Slider effectSlider;
    public AudioSource bgm;
    public AudioSource effectSound;

    private float bgmVol = 1f;
    private float effectVol = 1f;

    private static SoundControl instance = null;

    public static SoundControl Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }

    void Awake()
    {
        if (null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    void Start()
    {
        bgmVol = PlayerPrefs.GetFloat("bgmVol", 1f);
        bgmSlider.value = bgmVol;
        bgm.volume = bgmSlider.value;

        effectVol = PlayerPrefs.GetFloat("effectVol", 1f);
        effectSlider.value = effectVol;
        effectSound.volume = effectSlider.value;
    }


    public void SetBGMVolume(float volume)
    {
        bgm.volume = volume;
        PlayerPrefs.SetFloat("bgmVol", volume);
    }

    public void SetEffectVolume(float volume)
    {
        effectSound.volume = volume;
        PlayerPrefs.SetFloat("effectVol", volume);
    }
}
