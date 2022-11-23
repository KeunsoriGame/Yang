using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainController : MonoBehaviour
{
<<<<<<< HEAD
    private static mainController instance = null;

    public static mainController Instance
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


    //미니게임으로 씬 전환
=======
    public GameObject ButtonEffect;
>>>>>>> Baek-1
    public void MainToMinigame()
    {
        int randNum = Random.Range(1, 3);
        if(randNum == 1)
        {
            SceneManager.LoadScene("MiniGame1");
            ButtonEffect.SetActive(false);

        }

        else if(randNum == 2)
        {
            SceneManager.LoadScene("MiniGame2");
            ButtonEffect.SetActive(false);
        }

    }

    //메인화면으로 씬 전환
    public void MainToHome()
    {
        SceneManager.LoadScene("HomeScene");
        ButtonEffect.SetActive(false);
    }
}
