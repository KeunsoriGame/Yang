using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinScore : MonoBehaviour
{
    public static CoinScore instance;
    public Text coinText;
    private int coin = 0;

    void Awake()
    {
        if (!instance)
        {
            instance = this;
            Debug.Log(0);
        }
    }

    public void AddCoin(int num)
    {
        coin += num;
        coinText.text = "Coin : " + coin;
    }

    void Start ()
    {

    }

    void Update()
    {

    }
}
