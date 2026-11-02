using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float rollTorque = 15f;
    [SerializeField] private float maxAngularSpeed = 500f;
    [SerializeField] private float jumpForce = 8f;
    [SerializeField] private int maxJumps = 2;

    private int jumpCount = 0;
    private bool isGrounded = false;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < maxJumps)
    {
        rb.velocity = new Vector2(rb.velocity.x, 0f);
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        jumpCount++;
    }
        
    }

    void FixedUpdate()
    {
        float movement = Input.GetAxis("Horizontal");

        rb.AddTorque(-movement * rollTorque);

        rb.velocity = new Vector2(
            movement * 5f,
            rb.velocity.y
        );

        rb.angularVelocity = Mathf.Clamp(
            rb.angularVelocity,
            -maxAngularSpeed,
            maxAngularSpeed
        );
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
    if (collision.gameObject.CompareTag("Ground"))
    {
        jumpCount = 0;
        isGrounded = true;
    }
    }   

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}