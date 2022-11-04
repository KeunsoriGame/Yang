using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainController : MonoBehaviour
{
    public void MainToMinigame()
    {
        int number = Random.Range(1, 3);

        if (number == 1)
        {
            SceneManager.LoadScene("MiniGame1");
        }

        else if(number == 2)
        {
            SceneManager.LoadScene("MiniGame2");
        }
        
    }

    public void MainToHome()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
