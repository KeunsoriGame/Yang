using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainController : MonoBehaviour
{
    public void MainToMinigame()  // ȭ�� ��ȯ
    {
        SceneManager.LoadScene("MiniGame2");
    }

    public void MainToHome() // ȭ�� ��ȯ
    {
        SceneManager.LoadScene("HomeScene");
    }


    public GameObject lvlpopup = null;
    public void BandLevelUP() // �����ϱ� ��ư
    {
        lvlpopup.SetActive(true);
    }
}
