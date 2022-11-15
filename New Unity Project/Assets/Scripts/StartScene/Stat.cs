using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat : MonoBehaviour
{
    private static Stat instance = null;

    public int level = 1; // 밴드 레벨

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
    public int[] session = new int[5];  // 개인연습한 세션 찾기 용도

    public static Stat Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }

    void Awake()
    {
        if (null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {        
        for(int i=0; i<5; i++)
        {
            session[i] = 0;
        }
    }

    void Update()
    {
        
    }


    public int GetStatSum()
    {
        return d_ex + d_conf + g_ex + g_conf + b_ex + b_conf + k_ex + k_conf + v_ex + v_conf;
    }
}
