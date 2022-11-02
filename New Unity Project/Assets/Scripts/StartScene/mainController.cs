using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainController : MonoBehaviour
{
    public void MainToMinigame()  // 화면 전환
    {
        SceneManager.LoadScene("MiniGame2");
    }

    public void MainToHome() // 화면 전환
    {
        SceneManager.LoadScene("HomeScene");
    }


    public GameObject lvlpopup = null;
    public void BandLevelUP() // 합주하기 버튼
    {
        lvlpopup.SetActive(true);
    }
}
