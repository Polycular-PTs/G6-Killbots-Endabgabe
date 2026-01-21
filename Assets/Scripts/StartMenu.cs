
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public void LoadGame()
    {
        Scenes.Load(Scenes.SceneType.Game);
    }

    public void LoadSettings()
    {
        Scenes.Load(Scenes.SceneType.Settings);
    }

    public void LoadInstagram()
    {
        Scenes.Load(Scenes.SceneType.Instagram);
    }

    public void LoadRecognizingBots()
    {
        Scenes.Load(Scenes.SceneType.RecognizingBots);
    }
}
