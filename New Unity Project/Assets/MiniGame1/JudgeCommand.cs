using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JudgeCommand : MonoBehaviour
{
    [SerializeField] GameObject state;
    public int i = 0;

    public void ButtonA()
    {
        if (state.transform.GetChild(i).name == "A(Clone)")
        {
            state.transform.GetChild(i).gameObject.SetActive(false);
            ++i;
        }
    }

    public void ButtonB()
    {
        if (state.transform.GetChild(i).name == "B(Clone)")
        {
            state.transform.GetChild(i).gameObject.SetActive(false);
            ++i;
        }
    }

    public void ButtonC()
    {
        if (state.transform.GetChild(i).name == "C(Clone)")
        {
            state.transform.GetChild(i).gameObject.SetActive(false);
            ++i;
        }
    }

    public void ButtonD()
    {
        if (state.transform.GetChild(i).name == "D(Clone)")
        {
            state.transform.GetChild(i).gameObject.SetActive(false);
            ++i;
        }
    }

    public void ButtonE()
    {
        if (state.transform.GetChild(i).name == "E(Clone)")
        {
            state.transform.GetChild(i).gameObject.SetActive(false);
            ++i;
        }
    }

    public void ButtonF()
    {
        if (state.transform.GetChild(i).name == "F(Clone)")
        {
            state.transform.GetChild(i).gameObject.SetActive(false);
            ++i;
        }
    }
}
