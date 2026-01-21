using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public enum SceneType
    {
        Game,
        Settings,
        Instagram,
        RecognizingBots
    }

    public static void Load(SceneType scene)
    {
        SceneManager.LoadScene(scene.ToString() + "Scene");
    }
}
