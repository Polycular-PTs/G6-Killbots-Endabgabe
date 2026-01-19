using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSetup : MonoBehaviour
{
    
    void Start()
    {
        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.FindAndSetScoreText();
        }
    }

    
    void Update()
    {

    }

}
