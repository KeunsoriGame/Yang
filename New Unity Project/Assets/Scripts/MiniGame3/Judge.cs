using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    public GameObject[] state;

    float x, y;
    private void Start()
    {
        Vector2 ClickPos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        x = ClickPos.x;
        y = ClickPos.y;
    }
    void Click()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(x >= 600 && x < 850)
            {
                if(y <= 900 && y > 650)
                {
                    Debug.Log("0");
                    state[0].transform.GetChild(1).gameObject.SetActive(false);
                }

                else if (y <= 650 && y > 400)
                {
                    state[1].transform.GetChild(1).gameObject.SetActive(false);
                }

                else if (y <= 400 && y > 150)
                {
                    state[2].transform.GetChild(1).gameObject.SetActive(false);
                }

                else if (y <= 150 && y > -100)
                {
                    state[3].transform.GetChild(1).gameObject.SetActive(false);
                }

                else
                {
                    return;
                }
            }
            
            else if(x >= 850 && x < 1100)
            {
                if (y <= 900 && y > 650)
                {
                    state[4].transform.GetChild(1).gameObject.SetActive(false);
                }

                else if (y <= 650 && y > 400)
                {
                    state[5].transform.GetChild(1).gameObject.SetActive(false);
                }

                else if (y <= 400 && y > 150)
                {
                    state[6].transform.GetChild(1).gameObject.SetActive(false);
                }

                else if (y <= 150 && y > -100)
                {
                    state[7].transform.GetChild(1).gameObject.SetActive(false);
                }

                else
                {
                    return;
                }
            }

            else if(x >= 1100 && x < 1350)
            {
                if (y <= 900 && y > 650)
                {
                    state[8].transform.GetChild(1).gameObject.SetActive(false);
                }

                else if (y <= 650 && y > 400)
                {
                    state[9].transform.GetChild(1).gameObject.SetActive(false);
                }

                else if (y <= 400 && y > 150)
                {
                    state[10].transform.GetChild(1).gameObject.SetActive(false);
                }

                else if (y <= 150 && y > -100)
                {
                    state[11].transform.GetChild(1).gameObject.SetActive(false);
                }

                else
                {
                    return;
                }
            }

            else if(x >= 1350 && x < 1600)
            {
                if (y <= 900 && y > 650)
                {
                    state[12].transform.GetChild(1).gameObject.SetActive(false);
                }

                else if (y <= 650 && y > 400)
                {
                    state[13].transform.GetChild(1).gameObject.SetActive(false);
                }

                else if (y <= 400 && y > 150)
                {
                    state[14].transform.GetChild(1).gameObject.SetActive(false);
                }

                else if (y <= 150 && y > -100)
                {
                    state[15].transform.GetChild(1).gameObject.SetActive(false);
                }
            }
        }
    }
}
