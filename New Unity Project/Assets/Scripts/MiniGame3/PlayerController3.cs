using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3 : MonoBehaviour
{
    public GameObject gameManager; // ���� �Ŵ��� ��ũ��Ʈ

    // public AudioClip deathClip;  //���ӿ��� �����
    public float jumpForce = 700f;  // ���� ��

    private int jumpCount = 0; // ���� Ƚ��
    private bool isGrounded = false; // �ٴڿ� ��Ҵ���
    private bool isDead = false; // ���

    private Rigidbody2D playerRigidbody;

    private Animator animator;
    // private AudioSource playerAudio; // �÷��� �����

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
            // ��� �� 
        }

        if (Input.GetMouseButtonDown(0) && jumpCount < 2)
        {
            jumpCount++;
            playerRigidbody.velocity = Vector2.zero; // ���� ���� �ӵ��� 0����
            playerRigidbody.AddForce(new Vector2(0, jumpForce));  // �������� ���ֱ�

            //playerAudio.Play();
        }

        else if (Input.GetMouseButtonUp(0) && playerRigidbody.velocity.y > 0)
        {
            // ��� ���̸� �ӵ� 1/2
            playerRigidbody.velocity = playerRigidbody.velocity * 0.5f;
        }

        animator.SetBool("Grounded", isGrounded);
    }

    private void Die()
    {
        animator.SetTrigger("Die");

        // playerAudio.clip = deathCip;  //���ӿ��� ����� ���
        // playerAudio.Play();

        playerRigidbody.velocity = Vector2.zero;

        isDead = true;

        gameManager.GetComponent<GameManager3>().PlayerDead();
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
            // � �ݶ��̴��� ��� �浹ǥ���� ����
            isGrounded = true;
            jumpCount = 0;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}