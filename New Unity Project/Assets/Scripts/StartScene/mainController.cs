using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainController : MonoBehaviour
{
    public GameObject ButtonEffect;
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

    public void MainToHome()
    {
        SceneManager.LoadScene("HomeScene");
        ButtonEffect.SetActive(false);
    }
}
