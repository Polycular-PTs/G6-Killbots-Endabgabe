using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctionality : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Spiel wird beendet...");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }

    public void PlayAgain()
    {
        ScoreManager.Instance.ResetScore();
        ScoreManager.Instance.scoreText = null;
        SceneManager.LoadScene("GameScene");
    }

    public void RecognizingBots()
    {
        SceneManager.LoadScene("RecognizingBots");
    }
   
}
