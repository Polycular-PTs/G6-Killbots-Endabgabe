using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boden : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float resetPositionX = -20f;
    [SerializeField] private float startPositionX = 20f;  

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < resetPositionX)
        {
            Vector2 newPos = new Vector2(startPositionX, transform.position.y);
            transform.position = newPos;
        }
    }
}
