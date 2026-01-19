using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public float gameDuration = 300f; 
    private float timeRemaining;
    private bool timerActive = true;

    [Header("UI References")]
    public TextMeshProUGUI timerText; 
    public Canvas timerCanvas;

    
    void Start()
    {
        timeRemaining = gameDuration;
        UpdateTimerDisplay(); 
    }

    void Update()
    {
        if (!timerActive) return;

        timeRemaining -= Time.deltaTime;
        UpdateTimerDisplay();

        if (timeRemaining <= 0)
        {
            timeRemaining = 0;
            timerActive = false;
            SceneManager.LoadScene("EndScene");
        }

       
    }

    void UpdateTimerDisplay()
    {
        if (timerText != null)
        {
            int minutes = Mathf.FloorToInt(timeRemaining / 60);
            int seconds = Mathf.FloorToInt(timeRemaining % 60);
            timerText.text = $"{minutes:00}:{seconds:00}";
        }
    }
}
