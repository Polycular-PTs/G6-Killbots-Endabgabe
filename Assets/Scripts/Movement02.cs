using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement02 : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float sprintSpeed = 9f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
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
