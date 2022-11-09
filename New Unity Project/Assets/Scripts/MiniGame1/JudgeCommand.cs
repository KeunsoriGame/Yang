using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JudgeCommand : MonoBehaviour
{
    [SerializeField] GameObject state;
    int correctNumber = 0;
    int wrongNumber = 0;

    public void ButtonA()
    {
        if (state.transform.GetChild(correctNumber).name == "A(Clone)")
        {
            state.transform.GetChild(correctNumber).gameObject.SetActive(false);
            ++correctNumber;
        }

        else
        {
            ++wrongNumber;
        }
    }

    public void KeyA()
    {
        if(Input.GetKeyDown("a"))
        {
            if (state.transform.GetChild(correctNumber).name == "A(Clone)")
            {
                state.transform.GetChild(correctNumber).gameObject.SetActive(false);
                ++correctNumber;
            }

            else
            {
                ++wrongNumber;
            }
        }
    }

    public void ButtonB()
    {
        if (state.transform.GetChild(correctNumber).name == "B(Clone)")
        {
            state.transform.GetChild(correctNumber).gameObject.SetActive(false);
            ++correctNumber;
        }

        else
        {
            ++wrongNumber;
        }
    }

    public void KeyB()
    {
        if (Input.GetKeyDown("b"))
        {
            if (state.transform.GetChild(correctNumber).name == "B(Clone)")
            {
                state.transform.GetChild(correctNumber).gameObject.SetActive(false);
                ++correctNumber;
            }

            else
            {
                ++wrongNumber;
            }
        }
    }
    public void ButtonC()
    {
        if (state.transform.GetChild(correctNumber).name == "C(Clone)")
        {
            state.transform.GetChild(correctNumber).gameObject.SetActive(false);
            ++correctNumber;
        }

        else
        {
            ++wrongNumber;
        }
    }

    public void KeyC()
    {
        if (Input.GetKeyDown("c"))
        {
            if (state.transform.GetChild(correctNumber).name == "C(Clone)")
            {
                state.transform.GetChild(correctNumber).gameObject.SetActive(false);
                ++correctNumber;
            }

            else
            {
                ++wrongNumber;
            }
        }
    }

    public void ButtonD()
    {
        if (state.transform.GetChild(correctNumber).name == "D(Clone)")
        {
            state.transform.GetChild(correctNumber).gameObject.SetActive(false);
            ++correctNumber;
        }

        else
        {
            ++wrongNumber;
        }
    }

    public void KeyD()
    {
        if (Input.GetKeyDown("d"))
        {
            if (state.transform.GetChild(correctNumber).name == "D(Clone)")
            {
                state.transform.GetChild(correctNumber).gameObject.SetActive(false);
                ++correctNumber;
            }

            else
            {
                ++wrongNumber;
            }
        }
    }

    public void ButtonE()
    {
        if (state.transform.GetChild(correctNumber).name == "E(Clone)")
        {
            state.transform.GetChild(correctNumber).gameObject.SetActive(false);
            ++correctNumber;
        }

        else
        {
            ++wrongNumber;
        }
    }

    public void KeyE()
    {
        if (Input.GetKeyDown("e"))
        {
            if (state.transform.GetChild(correctNumber).name == "E(Clone)")
            {
                state.transform.GetChild(correctNumber).gameObject.SetActive(false);
                ++correctNumber;
            }

            else
            {
                ++wrongNumber;
            }
        }
    }

    public void ButtonF()
    {
        if (state.transform.GetChild(correctNumber).name == "F(Clone)")
        {
            state.transform.GetChild(correctNumber).gameObject.SetActive(false);
            ++correctNumber;
        }

        else
        {
            ++wrongNumber;
        }
    }

    public void KeyF()
    {
        if (Input.GetKeyDown("f"))
        {
            if (state.transform.GetChild(correctNumber).name == "F(Clone)")
            {
                state.transform.GetChild(correctNumber).gameObject.SetActive(false);
                ++correctNumber;
            }

            else
            {
                ++wrongNumber;
            }
        }
    }

    private void Update()
    {
        if(correctNumber >= 36)
        {
            GameObject.Find("Canvas").transform.GetChild(4).gameObject.SetActive(true);
        }

        if(wrongNumber >= 1)
        {
            GameObject.Find("Canvas").transform.GetChild(5).gameObject.SetActive(true);
        }

        KeyA();
        KeyB();
        KeyC();
        KeyD();
        KeyE();
        KeyF();
    }

    public void ReturnHome()
    {
        SceneManager.LoadScene("StartScene");
        GameObject.Find("Canvas").transform.GetChild(3).gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.GetChild(4).gameObject.SetActive(false);
        correctNumber = 0;
        wrongNumber = 0;
    }

    public void FirstOutCheck()
    {
        Time.timeScale = 0;
        GameObject.Find("Canvas").transform.GetChild(7).gameObject.SetActive(true);
    }

    public void ContinueOut()
    {
        GameObject.Find("Canvas").transform.GetChild(8).gameObject.SetActive(true);
    }

    public void RefuseOut()
    {
        Time.timeScale = 1;
        GameObject.Find("Canvas").transform.GetChild(7).gameObject.SetActive(false);
    }
}
