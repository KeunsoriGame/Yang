using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JudgeCommand : MonoBehaviour
{
    [SerializeField] GameObject A,B,C,D,E,F;
    static int i = 0;

    public void ButtonA()
    {
        while(i <= 5)
        {
            if (A==gameObject.transform.Find("Canvas").Find("Prefab").GetChild(i))
            {
                Destroy(gameObject.transform.GetChild(1).GetChild(2).GetChild(i));
                i++;
            }
        }
    }

    public void ButtonB()
    {
        while (i <= 5)
        {
            if (B == gameObject.transform.GetChild(1).GetChild(2).GetChild(i))
            {
                Destroy(gameObject.transform.GetChild(1).GetChild(2).GetChild(i));
                i++;
            }
        }
    }

    public void ButtonC()
    {
        while (i <= 5)
        {
            if (C == gameObject.transform.GetChild(1).GetChild(2).GetChild(i))
            {
                Destroy(gameObject.transform.GetChild(1).GetChild(2).GetChild(i));
                i++;
            }
        }
    }

    public void ButtonD()
    {
        while (i <= 5)
        {
            if (D == gameObject.transform.GetChild(1).GetChild(2).GetChild(i))
            {
                Destroy(gameObject.transform.GetChild(1).GetChild(2).GetChild(i));
                i++;
            }
        }
    }

    public void ButtonE()
    {
        while (i <= 5)
        {
            if (E == gameObject.transform.GetChild(1).GetChild(2).GetChild(i))
            {
                Destroy(gameObject.transform.GetChild(1).GetChild(2).GetChild(i));
                i++;
            }
        }
    }

    public void ButtonF()
    {
        while (i <= 5)
        {
            if (F == gameObject.transform.GetChild(1).GetChild(2).GetChild(i))
            {
                Destroy(gameObject.transform.GetChild(1).GetChild(2).GetChild(i));
                i++;
            }
        }
    }
}
