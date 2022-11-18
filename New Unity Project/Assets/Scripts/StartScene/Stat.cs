using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat : MonoBehaviour
{
    private static Stat instance = null;

    public int level = 1; // 밴드 레벨

    public int d_ex, d_conf;
    public int g_ex, g_conf;
    public int b_ex, b_conf;
    public int k_ex, k_conf;
    public int v_ex, v_conf;
    public int[] session = new int[5];  // 개인연습한 세션 찾기 용도


    //싱글톤
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

        SetData();
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

    private bool StatCmp(int s) // 스탯 총합 기준 확인
    {
        switch (level)
        {
            case 1:
                return s >= 18;
            case 2:
                return s >= 35;
            case 3:
                return s >= 58;
            case 4:
                return s >= 85;
            default:
                return true;
        }
    }

    public bool StatCmp2()  // 개별 스탯 기준 확인
    {
        return StatCmp(d_ex) && StatCmp(d_conf) && StatCmp(g_ex) && StatCmp(g_conf) && StatCmp(b_ex) && StatCmp(b_conf) && StatCmp(k_ex) && StatCmp(k_conf) && StatCmp(v_ex) && StatCmp(v_conf);
    }

    public void SetData()
    {
        level = PlayerPrefs.GetInt("level", 1);
        d_ex = PlayerPrefs.GetInt("dEx", 15);
        d_conf = PlayerPrefs.GetInt("dConf", 15);
        g_ex = PlayerPrefs.GetInt("gEx", 15);
        g_conf = PlayerPrefs.GetInt("gConf", 15);
        b_ex = PlayerPrefs.GetInt("bEx", 15);
        b_conf = PlayerPrefs.GetInt("bConf", 15);
        k_ex = PlayerPrefs.GetInt("kEx", 15);
        k_conf = PlayerPrefs.GetInt("kConf", 15);
        v_ex = PlayerPrefs.GetInt("vEx", 15);
        v_conf = PlayerPrefs.GetInt("vConf", 15);
    }

}
