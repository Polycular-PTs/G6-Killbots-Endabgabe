using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boden : MonoBehaviour
{
    public float speed = 5f; 
    public float resetPositionX = -20f; 
    public float startPositionX = 20f;  

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < resetPositionX)
        {
            Vector2 newPos = new Vector2(startPositionX, transform.position.y);
            transform.position = newPos;
        }
    }
}
