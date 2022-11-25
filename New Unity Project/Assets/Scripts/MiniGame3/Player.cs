using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public AudioSource[] sound;
    public GameManager gameManager;
    public bool isleft = true, isDie = false;
    public int characterIndex, stairIndex;

    public void Climb(bool isChange)
    {
        if (isChange) isleft = !isleft;
        gameManager.StairMove(stairIndex, isChange, isleft);
        if ((++stairIndex).Equals(20)) stairIndex = 0;
        MoveAnimation();
        gameManager.gaugeStart = true;
    }


    public void MoveAnimation()
    {
        //Change left and right when changing direction
        if (!isleft)
            transform.rotation = Quaternion.Euler(0, -180, 0);
        else
            transform.rotation = Quaternion.Euler(0, 0, 0);

        if (isDie) return;
        Invoke("IdleAnimation", 0.05f);
    }
}
