using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainController : MonoBehaviour
{
    public void MainToMinigame()
    {
        SceneManager.LoadScene("MiniGame2");
    }

    public void MainToHome()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
