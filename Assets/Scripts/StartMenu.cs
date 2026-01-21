
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
  
    public void GameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void SettingsScene()
    {
        SceneManager.LoadScene("SettingsScene");
    }


    public void InstagramScene()
    {
        SceneManager.LoadScene("InstagramScene");
    }

    public void RecognizingBots()
    {
        SceneManager.LoadScene("RecognizingBots");
    }


}
