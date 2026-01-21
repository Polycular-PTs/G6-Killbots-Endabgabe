
using UnityEngine;

public class ScoreSetup : MonoBehaviour
{
    
    private void Start()
    {
        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.FindAndSetScoreText();
        }
    }

}
