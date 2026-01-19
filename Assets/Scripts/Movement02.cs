using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement02 : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float sprintSpeed = 9f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float move = 0f;
        float speed = moveSpeed;

        if (Input.GetKey(KeyCode.A))
            move = -moveSpeed;

        if (Input.GetKey(KeyCode.D))
            move = moveSpeed;

   
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
            speed = sprintSpeed;

        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0f,9f), ForceMode2D.Impulse);
            
        }
    }

}
