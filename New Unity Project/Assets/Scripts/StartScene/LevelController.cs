using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public Text levelText;
    int level;
    int statSum;

    public GameObject load;
    public GameObject levelup;
    public GameObject levelupfail;
    


    void Start()
    {
        level = GameObject.Find("mainControl").GetComponent<Stat>().level;
        levelText.text = "밴드 Lv." + level.ToString();
        //DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        
    }

    public void LevelManager()  // 합주하기 버튼 클릭 시
    {
        load.SetActive(true);

        statSum = GameObject.Find("mainControl").GetComponent<Stat>().GetStatSum();

        if (LevelCmp1(statSum) && GameObject.Find("mainControl").GetComponent<Stat>().StatCmp2())
        {
            Invoke("LevelUP", 3f);
            level++;
            levelText.text = "밴드 Lv." + level.ToString();
        }
        else
            Invoke("LevelUPFail", 3f);
        
    }

    void LevelUP()  // 합주 성공
    {
        load.SetActive(false);
        levelup.SetActive(true);

        PlayerPrefs.SetInt("level", level);

    }

    void LevelUPFail()  // 합주 실패
    {
        load.SetActive(false);;
        levelupfail.SetActive(true);
    }


    bool LevelCmp1(int sum) // 레벨 별 조건과 스탯 합 비교
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
