using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3 : MonoBehaviour
{
    // public AudioClip deathClip;  //게임오버 오디오
    public float jumpForce = 700f;  // 점프 힘

    private int jumpCount = 0; // 점프 횟수
    private bool isGrounded = false; // 바닥에 닿았는지
    private bool isDead = false; // 사망

    private Rigidbody2D playerRigidbody;

    private Animator animator;
    // private AudioSource playerAudio; // 플레이 오디오

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        //playerAudio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (isDead)
        {
            // 사망 시 
        }

        if(Input.GetMouseButtonDown(0) && jumpCount < 2)
        {
            jumpCount++;
            playerRigidbody.velocity = Vector2.zero; // 점프 직전 속도를 0으로
            playerRigidbody.AddForce(new Vector2(0, jumpForce));  // 위쪽으로 힘주기

            //playerAudio.Play();
        }

        else if (Input.GetMouseButtonUp(0) && playerRigidbody.velocity.y > 0)
        {
            // 상승 중이면 속도 1/2
            playerRigidbody.velocity = playerRigidbody.velocity * 0.5f;
        }

        animator.SetBool("Grounded", isGrounded);
    }

    private void Die()
    {
        animator.SetTrigger("Die");

        // playerAudio.clip = deathCip;  //게임오버 오디오 재생
        // playerAudio.Play();

        playerRigidbody.velocity = Vector2.zero;

        isDead = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Dead" && !isDead)
        {
            Die();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.contacts[0].normal.y > 0.7f)
        {
            // 어떤 콜라이더와 닿고 충돌표면이 위쪽
            isGrounded = true;
            jumpCount = 0;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}
