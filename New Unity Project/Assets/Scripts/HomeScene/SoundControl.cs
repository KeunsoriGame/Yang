using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

    
    // bgm 볼륨 조절
    public void SetBGMVolume(float volume)
    {
        bgm.volume = volume;
        PlayerPrefs.SetFloat("bgmVol", volume);
    }

    //효과음 볼륨 조절
    public void SetEffectVolume(float volume)
    {
        effectSound.volume = volume;
        PlayerPrefs.SetFloat("effectVol", volume);
    }
   
    public void PlayBgm(float volume)
    {
        if (SceneManager.GetActiveScene().name == "StartScene")
        {
            bgm.Play();
        }

        if(SceneManager.GetActiveScene().name=="MiniGame1" || SceneManager.GetActiveScene().name == "MiniGame2")
        {
            bgm.Stop();
        }
    }
}
