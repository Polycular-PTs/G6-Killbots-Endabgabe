using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement02 : MonoBehaviour
{
    private const float MOVE_LEFT = -1f;
    private const float MOVE_RIGHT = 1f;
    private const float JUMP_FORCE = 9f;

    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float sprintSpeed = 9f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveDirection = 0f;
        float currentSpeed = moveSpeed;

        if (Input.GetKey(KeyCode.A))
            moveDirection = MOVE_LEFT;

        if (Input.GetKey(KeyCode.D))
            moveDirection = MOVE_RIGHT;

   
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
            currentSpeed = sprintSpeed;

        rb.linearVelocity = new Vector2(moveDirection * currentSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * JUMP_FORCE, ForceMode2D.Impulse);
            
        }
    }

}
