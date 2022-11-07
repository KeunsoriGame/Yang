using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat : MonoBehaviour
{

    public int d_ex = 0;
    public int d_conf = 0;
    public int g_ex = 0;
    public int g_conf = 0;
    public int b_ex = 0;
    public int b_conf = 0;
    public int k_ex = 0;
    public int k_conf = 0;
    public int v_ex = 0;
    public int v_conf = 0;


    void Start()
    {
        
    }

    void Update()
    {
        
    }


    public int GetStatSum()
    {
        return d_ex + d_conf + g_ex + g_conf + b_ex + b_conf + k_ex + k_conf + v_ex + v_conf;
    }
}
