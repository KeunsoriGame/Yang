using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject gameover; // 게임오버 팝업창
    public Text Ytext; // score 텍스트
    private int score; // 아이템 획득 횟수

    public AudioSource YellowCrashSound;
    public GameObject YellowCrash;
    public AudioSource RedCrashSound;
    public GameObject RedCrash;

    void Start()
    {
        score = 0;
        Ytext.text = "score : " + score;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            this.transform.Translate(-50, 0, 0);

        if (Input.GetKeyDown(KeyCode.RightArrow))
            this.transform.Translate(50, 0, 0);

        // 카메라 영역 밖 제한

    }

    public void LBottonDown()
    {
        transform.Translate(-50, 0, 0);
    }

    public void RBottonDown()
    {
        transform.Translate(50, 0, 0);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            other.gameObject.SetActive(false);
            gameover.gameObject.SetActive(true);
            Time.timeScale = 0;
            Debug.Log("Game Over");
            RedCrash.SetActive(true);
            RedCrashSound.Play();


            //스탯 하락
            int i = 0;
            for (i = 0; i < 5; i++)  // 어떤 세션인지 찾기
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
                    Stat.Instance.d_ex -= 3;
                    Stat.Instance.d_conf -= 3;
                    PlayerPrefs.SetInt("dEx", Stat.Instance.d_ex);
                    PlayerPrefs.SetInt("dConf", Stat.Instance.d_conf);
                    break;
                case 1:
                    Stat.Instance.g_ex -= 3;
                    Stat.Instance.g_conf -= 3;
                    PlayerPrefs.SetInt("gEx", Stat.Instance.g_ex);
                    PlayerPrefs.SetInt("gConf", Stat.Instance.g_conf);
                    break;
                case 2:
                    Stat.Instance.b_ex -= 3;
                    Stat.Instance.b_conf -= 3;
                    PlayerPrefs.SetInt("bEx", Stat.Instance.b_ex);
                    PlayerPrefs.SetInt("bConf", Stat.Instance.b_conf);
                    break;
                case 3:
                    Stat.Instance.k_ex -= 3;
                    Stat.Instance.k_conf -= 3;
                    PlayerPrefs.SetInt("kEx", Stat.Instance.k_ex);
                    PlayerPrefs.SetInt("kConf", Stat.Instance.k_conf);
                    break;
                case 4:
                    Stat.Instance.v_ex -= 3;
                    Stat.Instance.v_conf -= 3;
                    PlayerPrefs.SetInt("vEx", Stat.Instance.v_ex);
                    PlayerPrefs.SetInt("vConf", Stat.Instance.v_conf);
                    break;
                default:
                    break;
            }

        }

        else if (other.gameObject.tag == "item")
        {
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);

            //아이템 획득 횟수 표시
            score += 1;
            Ytext.text = "score : " + score;
            YellowCrash.SetActive(true);
            YellowCrashSound.Play();
        }
    }
}

