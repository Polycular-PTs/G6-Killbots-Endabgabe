using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float smoothing = 5f;
    [SerializeField] private Vector3 offset = new Vector3(0f, 0f, -10f); 

    private void LateUpdate()
    {
        if (target != null)
        {
            
            Vector3 targetPosition = target.position + offset;

            
            transform.position = Vector3.Lerp(
                transform.position,
                targetPosition,
                smoothing * Time.deltaTime
            );
        }
    }
}
