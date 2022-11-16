using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HometoMain : MonoBehaviour
{
    public GameObject ButtonEffect;

    public void SceneChange()
    {
        SceneManager.LoadScene("StartScene");
        ButtonEffect.SetActive(false);
    }
}
