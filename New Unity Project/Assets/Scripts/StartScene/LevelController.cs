using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public Text levelText;
    int level;

    int statSum = 0;

    public GameObject load;
    public GameObject levelup;
    public GameObject levelupfail;
    public GameObject statSc;


    

    void Start()
    {
        level = GameObject.Find("mainControl").GetComponent<Stat>().level;
        levelText.text = "��� Lv." + level.ToString();
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        
    }

    public void LevelManager()  // �����ϱ� ��ư Ŭ�� ��
    {
        load.SetActive(true);

        statSum = statSc.GetComponent<Stat>().GetStatSum();

        if (LevelCmp(statSum))
        {
            Invoke("LevelUP", 3f);
            level++;
            levelText.text = "��� Lv." + level.ToString();
        }
        else
            Invoke("LevelUPFail", 3f);
        
    }

    void LevelUP()  // ���� ����
    {
        load.SetActive(false);
        levelup.SetActive(true);

    }

    void LevelUPFail()  // ���� ����
    {
        load.SetActive(false);
        levelupfail.SetActive(true);
    }

    bool LevelCmp(int sum) // ���� �� ���ǰ� ���� �� ��
    {
        int s = sum;
        switch (level)
        {
            case 1:
                return s >= 100;
            case 2:
                return s >= 220;
            case 3:
                return s >= 340;
            case 4:
                return s >= 460;
            default:
                return true;
        }
    }

   

}
