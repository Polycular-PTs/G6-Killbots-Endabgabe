using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndGameUI : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private TextMeshProUGUI resultText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Color winColor = Color.green;
    [SerializeField] private Color loseColor = Color.red;

    
    private void Start()
    {
        
        int finalScore = ScoreManager.Instance.GetScore();
        UpdateUI();
    }


    private void UpdateUI() 
    {
        Debug.Log(ScoreManager.Instance.Success);
        Debug.Log(ScoreManager.Instance.GetScore());
        Debug.Log(ScoreManager.Instance.GetMaxScore());
       
        resultText.text = ScoreManager.Instance.Success ? "You won!" : "You've lost!";
        resultText.color = ScoreManager.Instance.Success ? winColor : loseColor;

       
        string successMessage = $"You've reached over 80%.\r\nGood job!";
        string failureMessage = $"You've got under 80%.\r\nTry again!";
        scoreText.text = ScoreManager.Instance.Success ? successMessage : failureMessage;
    }
}
