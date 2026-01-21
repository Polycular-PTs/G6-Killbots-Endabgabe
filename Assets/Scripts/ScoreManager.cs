using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    private int maxScore = 0;
    private int score = 0;

    private const float SUCCES_THRESHOLD = 0.8f;

    [Header("UI References")]
    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable() { SceneManager.sceneLoaded += OnSceneLoaded; }
    private void OnDisable() { SceneManager.sceneLoaded -= OnSceneLoaded; }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "GameScene") { FindAndSetScoreText(); }
    }

    public void FindAndSetScoreText()
    {
        GameObject scoreObj = GameObject.Find("ScoreText");
        if (scoreObj != null)
        {
            scoreText = scoreObj.GetComponent<TextMeshProUGUI>();
            UpdateScoreDisplay();
        }
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreDisplay();
    }

    public void AddMaxScore(int point)
    {
        maxScore += point;
        UpdateScoreDisplay();
    }

    
    public int GetScore() { return score; }
    public int GetMaxScore() { return maxScore; }

    public void ResetScore()
    {
        score = 0;
        maxScore = 0;
        UpdateScoreDisplay();
    }

    public bool Success => maxScore > 0 && (float)score / maxScore >= SUCCES_THRESHOLD;

    public void UpdateScoreDisplay()
    {
        if (scoreText != null)
        {
            scoreText.text = score.ToString();
            scoreText.color = Success ? Color.green : Color.red;
        }
    }
}
