using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnHome : MonoBehaviour
{
    public string FOC, COC;
    public GameObject ButtonEffect;
    public void RHome()
    {
        SceneManager.LoadScene("StartScene");
        ButtonEffect.SetActive(false);

    }

    public void FirstOutCheck()
    {
        Time.timeScale = 0;
        GameObject.Find("Canvas").transform.Find(FOC).gameObject.SetActive(true);
    }

    public void ContinueOut()
    {
        GameObject.Find("Canvas").transform.Find(COC).gameObject.SetActive(true);
    }

    public void RefuseOut()
    {
        Time.timeScale = 1;
        GameObject.Find("Canvas").transform.Find(FOC).gameObject.SetActive(false);
    }
}
