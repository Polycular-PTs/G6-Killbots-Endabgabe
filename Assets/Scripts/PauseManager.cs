using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using JetBrains.Annotations;

public class PauseManager : MonoBehaviour
{

   [SerializeField] private GameObject pauseCanvas;
    public static PauseManager Instance;
   [SerializeField] private GameObject pauseMenuPanel;
   [SerializeField] private GameObject hintsPanel;
   [SerializeField] private GameObject characterSelectionPanel;
   [SerializeField] private GameObject volumePanel;

   [SerializeField] private GameObject playerObject;
   [SerializeField] private SpriteRenderer playerRenderer;
   [SerializeField] private Sprite[] playerSprites;

   [SerializeField] private Slider volumeSlider;
   [SerializeField] private AudioSource mainAudioSource;

   [SerializeField] private GameObject hintsOverlay;

    private bool isPaused = false;
    public bool IsPaused => isPaused;

    private bool keepCharacterSelectionOpen = false;


    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        pauseCanvas.SetActive(false);
        pauseMenuPanel.SetActive(false);
        characterSelectionPanel.SetActive(false);
        hintsOverlay.SetActive(false);
        hintsPanel.SetActive(false);

        if (volumeSlider != null)
            volumeSlider.onValueChanged.AddListener(SetVolume);

        if (mainAudioSource != null)
            volumeSlider.value = mainAudioSource.volume;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            TogglePauseMenu();

            if (isPaused && keepCharacterSelectionOpen)
                characterSelectionPanel.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            ToggleHints();
        }
    }


    public void TogglePauseMenu()
    {
        isPaused = !isPaused;
        pauseCanvas.SetActive(true);
        pauseMenuPanel.SetActive(isPaused);
        characterSelectionPanel.SetActive(true);

        if (isPaused)
        {
            hintsPanel.SetActive(true);

            if (keepCharacterSelectionOpen)
                characterSelectionPanel.SetActive(true);
        }
        else
        {
            pauseMenuPanel.SetActive(false);
        }

        Time.timeScale = isPaused ? 0f : 1f;
    }


    public void ToggleHints()
    {
        bool overlayActive = hintsOverlay.activeSelf;

        pauseCanvas.SetActive(true);
        if (!isPaused)
        {
            hintsOverlay.SetActive(!overlayActive);
            return;
        }

        pauseCanvas.SetActive(true);
        pauseMenuPanel.SetActive(true);

        hintsPanel.SetActive(true);
        hintsOverlay.SetActive(!overlayActive);
    }

    public void ShowHints()
    {
        if (!isPaused) return;
        hintsPanel.SetActive(true);
        hintsOverlay.SetActive(true);
    }

    public void HideHints()
    {
        hintsPanel.SetActive(false);
        hintsOverlay.SetActive(false);
    }


    public void ToggleCharacterSelection()
    {
        bool isActive = characterSelectionPanel.activeSelf;

        if (!isActive)
        {
            keepCharacterSelectionOpen = true;

            if (!isPaused)
            {
                isPaused = true;
                Time.timeScale = 0f;
                AudioListener.pause = true;
            }
        }

        characterSelectionPanel.SetActive(!isActive);
    }


    public void SelectCharacter(int index)
    {
        if (index < 0 || index >= playerSprites.Length)
        {
            Debug.LogWarning("Ungültiger Charakter-Index!");
            return;
        }

        if (playerRenderer != null)
        {
            playerRenderer.sprite = playerSprites[index];
        }

        Debug.Log("Charakter gewechselt zu: " + index);

        keepCharacterSelectionOpen = true;
    }


    public void ShowHintsOverlay()
    {
        if (!isPaused) return;
        hintsOverlay.SetActive(true);
    }

    public void HideHintsOverlay()
    {
        hintsOverlay.SetActive(false);
    }

    public void SetVolume(float value)
    {
        if (mainAudioSource != null)
            mainAudioSource.volume = value;
    }


    public void ResumeGame()
    {
        TogglePauseMenu();
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        ScoreManager.Instance.ResetScore();
        SceneManager.LoadScene("GameScene");
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
