using UnityEngine;

public class MovementCharacter : MonoBehaviour
{

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
        float move = 0f;
        float speed = moveSpeed;

        
        if (Input.GetKey(KeyCode.A))
        {
            move = -1f;  
        }
        if (Input.GetKey(KeyCode.D))
        {
            move = 1f;   
        }

        
        if (move > 0f && Input.GetKey(KeyCode.LeftShift))
        {
            speed = sprintSpeed;
        }

        
        if (move < 0f && transform.position.x <= startX)
        {
            move = 0f; 
            Vector3 pos = transform.position;
            pos.x = startX;
            transform.position = pos;
        }

        
        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0f, 9f), ForceMode2D.Impulse);
        }
    }
}
