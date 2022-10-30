using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MaintoGame : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("MiniGame2");
    }
}
