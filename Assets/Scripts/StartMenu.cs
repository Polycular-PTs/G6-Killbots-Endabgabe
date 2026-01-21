using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEditor;
using System;

public class StartMenu : MonoBehaviour
{
    private Scene previousSceneName;
    

    private int sceneindex;
    private int sceneToOpen;


    private void Start()
    {
        sceneindex = SceneManager.GetActiveScene().buildIndex;
        if (!PlayerPrefs.HasKey("previousScene" + sceneindex))
        {
            PlayerPrefs.SetInt("previousScene" + sceneindex, sceneindex);
        }

        sceneToOpen = PlayerPrefs.GetInt("previousScene" + sceneindex);



    }

    public void OnButtonClick()
    {
        SceneManager.LoadScene(sceneToOpen);
    }


    private void LoadSceneMode(Scene previousSceneName)
    {
        throw new NotImplementedException();
    }

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

    public void PauseScene()
    {
        SceneManager.LoadScene("PauseScene");
    }

    public void ExitGame()
    {
        Debug.Log("Spiel wird beendet...");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }


}
