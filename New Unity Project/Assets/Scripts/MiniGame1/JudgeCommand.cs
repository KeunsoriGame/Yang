using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JudgeCommand : MonoBehaviour
{
    [SerializeField] GameObject state;
    public GameObject Effect;
    public GameObject ButtonSound;
    int correctNumber = 0;
    int wrongNumber = 0;
    //public Text Gtext; //gold ÅØ½ºÆ®
    //private int gold; //gold È¹µæ È½¼ö

    /*void Start()
    {
        gold = 0;
        Gtext.text = "Gold : " + gold;
    }*/

    public void ButtonA()
    {
        if (state.transform.GetChild(correctNumber).name == "A(Clone)")
        {
            state.transform.GetChild(correctNumber).gameObject.SetActive(false);
            ++correctNumber;
        }

        else
        {
            ++wrongNumber;
        }
    }

    public void KeyA() //º¸ÄÃ
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            if (state.transform.GetChild(correctNumber).name == "A(Clone)")
            {
                state.transform.GetChild(correctNumber).gameObject.SetActive(false);
                ++correctNumber;
            }

            else
            {
                ++wrongNumber;
            }
        }
    }

    public void ButtonB()
    {
        if (state.transform.GetChild(correctNumber).name == "B(Clone)")
        {
            state.transform.GetChild(correctNumber).gameObject.SetActive(false);
            ++correctNumber;
        }

        else
        {
            ++wrongNumber;
        }
    }

    public void KeyB() //ÀÏ·º
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (state.transform.GetChild(correctNumber).name == "B(Clone)")
            {
                state.transform.GetChild(correctNumber).gameObject.SetActive(false);
                ++correctNumber;
            }

            else
            {
                ++wrongNumber;
            }
        }
    }
    public void ButtonC()
    {
        if (state.transform.GetChild(correctNumber).name == "C(Clone)")
        {
            state.transform.GetChild(correctNumber).gameObject.SetActive(false);
            ++correctNumber;
        }

        else
        {
            ++wrongNumber;
        }
    }

    public void KeyC() //¾îÄí
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (state.transform.GetChild(correctNumber).name == "C(Clone)")
            {
                state.transform.GetChild(correctNumber).gameObject.SetActive(false);
                ++correctNumber;
            }

            else
            {
                ++wrongNumber;
            }
        }
    }

    public void ButtonD()
    {
        ButtonSound.GetComponent<ButtonAudioController>().BassSound();
        if (state.transform.GetChild(correctNumber).name == "D(Clone)")
        {
            state.transform.GetChild(correctNumber).gameObject.SetActive(false);
            ++correctNumber;
        }

        else
        {
            ++wrongNumber;
        }
    }

    public void KeyD() //º£ÀÌ½º
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            ButtonSound.GetComponent<ButtonAudioController>().BassSound();
            if (state.transform.GetChild(correctNumber).name == "D(Clone)")
            {
                state.transform.GetChild(correctNumber).gameObject.SetActive(false);
                ++correctNumber;
            }

            else
            {
                ++wrongNumber;
            }
        }
    }

    public void ButtonE()
    {
        ButtonSound.GetComponent<ButtonAudioController>().KeyboardSound();
        if (state.transform.GetChild(correctNumber).name == "E(Clone)")
        {
            state.transform.GetChild(correctNumber).gameObject.SetActive(false);
            ++correctNumber;
        }

        else
        {
            ++wrongNumber;
        }
    }

    public void KeyE() //Å°º¸µå
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            ButtonSound.GetComponent<ButtonAudioController>().KeyboardSound();
            if (state.transform.GetChild(correctNumber).name == "E(Clone)")
            {
                state.transform.GetChild(correctNumber).gameObject.SetActive(false);
                ++correctNumber;
            }

            else
            {
                ++wrongNumber;
            }
        }
    }

    public void ButtonF()
    {
        ButtonSound.GetComponent<ButtonAudioController>().DrumSound();
        if (state.transform.GetChild(correctNumber).name == "F(Clone)")
        {
            state.transform.GetChild(correctNumber).gameObject.SetActive(false);
            ++correctNumber;
        }

        else
        {
            ++wrongNumber;
        }
    }

    public void KeyF() //µå·³
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ButtonSound.GetComponent<ButtonAudioController>().DrumSound();
            if (state.transform.GetChild(correctNumber).name == "F(Clone)")
            {
                state.transform.GetChild(correctNumber).gameObject.SetActive(false);
                ++correctNumber;
            }

            else
            {
                ++wrongNumber;
            }
        }
    }

    /*public void GoldAdd()
    {
        if (correctNumber % 6 == 0)
        {
            gold += 1;
            Gtext.text = "Gold : " + gold.ToString();
        }
    }*/

    private void Update()
    {
        if (correctNumber >= 36)
        {
            GameObject.Find("Canvas").transform.GetChild(4).gameObject.SetActive(true);

            // ½ºÅÈ »ó½Â
            int i = 0;
            for (i = 0; i < 5; i++)
            {
                if (Stat.Instance.session[i] == 1)
                {
                    Stat.Instance.session[i] = 0;
                    break;
                }
            }

            switch (i)
            {
                case 0:
                    Stat.Instance.d_ex += 5;
                    Stat.Instance.d_conf += 5;
                    PlayerPrefs.SetInt("dEx", Stat.Instance.d_ex);
                    PlayerPrefs.SetInt("dConf", Stat.Instance.d_conf);
                    break;
                case 1:
                    Stat.Instance.g_ex += 5;
                    Stat.Instance.g_conf += 5;
                    PlayerPrefs.SetInt("gEx", Stat.Instance.g_ex);
                    PlayerPrefs.SetInt("gConf", Stat.Instance.g_conf);
                    break;
                case 2:
                    Stat.Instance.b_ex += 5;
                    Stat.Instance.b_conf += 5;
                    PlayerPrefs.SetInt("bEx", Stat.Instance.b_ex);
                    PlayerPrefs.SetInt("bConf", Stat.Instance.b_conf);
                    break;
                case 3:
                    Stat.Instance.k_ex += 5;
                    Stat.Instance.k_conf += 5;
                    PlayerPrefs.SetInt("kEx", Stat.Instance.k_ex);
                    PlayerPrefs.SetInt("kConf", Stat.Instance.k_conf);
                    break;
                case 4:
                    Stat.Instance.v_ex += 5;
                    Stat.Instance.v_conf += 5;
                    PlayerPrefs.SetInt("vEx", Stat.Instance.v_ex);
                    PlayerPrefs.SetInt("vConf", Stat.Instance.v_conf);
                    break;
                default:
                    break;
            }
            
        }

        if(wrongNumber >= 1)
        {
            GameObject.Find("Canvas").transform.GetChild(5).gameObject.SetActive(true);
        }

        KeyA();
        KeyB();
        KeyC();
        KeyD();
        KeyE();
        KeyF();
    }

    public void ReturnHome()
    {
        SceneManager.LoadScene("StartScene");
        GameObject.Find("Canvas").transform.GetChild(3).gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.GetChild(4).gameObject.SetActive(false);
        correctNumber = 0;
        wrongNumber = 0;
    }

    public void FirstOutCheck()
    {
        Time.timeScale = 0;
        GameObject.Find("Canvas").transform.GetChild(7).gameObject.SetActive(true);
    }

    public void ContinueOut()
    {
        GameObject.Find("Canvas").transform.GetChild(8).gameObject.SetActive(true);
    }

    public void RefuseOut()
    {
        Time.timeScale = 1;
        GameObject.Find("Canvas").transform.GetChild(7).gameObject.SetActive(false);
        Effect.SetActive(false);
    }
}
