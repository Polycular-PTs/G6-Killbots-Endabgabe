using UnityEngine;

public class MovementCharacter : MonoBehaviour
{
    private const float MOVE_LEFT = -1f;
    private const float MOVE_RIGHT = 1f;
    private const float JUMP_FORCE = 9f;
    private const float NO_MOVEMENT = 0f;

    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float sprintSpeed = 9f;    

    private Rigidbody2D rb;
    private float startX;             


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
        startX = transform.position.x;
    }

    private void Update()
    {
        float moveDirection = NO_MOVEMENT; 
        float currentSpeed = moveSpeed;

        
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection = MOVE_LEFT;  
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection = MOVE_RIGHT;   
        }

        
        if (moveDirection ==  MOVE_RIGHT && Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = sprintSpeed;
        }

        
        if (moveDirection == MOVE_LEFT && transform.position.x <= startX)
        {
            moveDirection = NO_MOVEMENT; 
            Vector3 pos = transform.position;
            pos.x = startX;
            transform.position = pos;
        }

        
        rb.linearVelocity = new Vector2(moveDirection * currentSpeed, rb.linearVelocity.y);

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * JUMP_FORCE, ForceMode2D.Impulse);
        }
    }
}
