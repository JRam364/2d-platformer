using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public float jumpForce = 7f;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
         rb2d = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Horizontal movement
        rb2d.velocity = new Vector2(
            moveHorizontal * speed,
            rb2d.velocity.y
        );

         // Jump, add new velocity in positive x direction
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = new Vector2(
                rb2d.velocity.x,
                jumpForce
            );
        }
    }
}