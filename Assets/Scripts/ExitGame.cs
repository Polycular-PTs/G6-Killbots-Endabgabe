using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void ExitGameEndScene()
    {
        Debug.Log("Spiel wird beendet...");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
