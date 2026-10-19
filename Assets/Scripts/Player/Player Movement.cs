using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float rollTorque = 15f;
    [SerializeField] private float maxAngularSpeed = 500f;
    [SerializeField] private float jumpForce = 8f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        float movement = Input.GetAxis("Horizontal");

        rb.AddTorque(-movement * rollTorque);

        rb.angularVelocity = Mathf.Clamp(
            rb.angularVelocity,
            -maxAngularSpeed,
            maxAngularSpeed
        );
    }
}