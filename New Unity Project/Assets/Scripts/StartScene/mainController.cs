using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainController : MonoBehaviour
{
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

    public void MainToMinigame()
    {
        int randNum = Random.Range(1, 3);
        if(randNum == 1)
        {
            SceneManager.LoadScene("MiniGame1");
        }

        else if(randNum == 2)
        {
            SceneManager.LoadScene("MiniGame2");
        }

    }

    public void MainToHome()
    {
        SceneManager.LoadScene("HomeScene");
        
    }
}
