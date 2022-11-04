using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainController : MonoBehaviour
{
    public GameObject data;

    public void MainToMinigame()
    {
        SceneManager.LoadScene("MiniGame2");
        DontDestroyOnLoad(data);
    }

    public void MainToHome()
    {
        SceneManager.LoadScene("HomeScene");
        DontDestroyOnLoad(data);
    }
}
