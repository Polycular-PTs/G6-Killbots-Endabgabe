using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using JetBrains.Annotations;
using System;

public class SettingsManager : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private GameObject settingsCanvas;
    [SerializeField] private GameObject settingsMenuPanel;
    [SerializeField] private Slider volumeSlider;

    [Header("Audio")]
    [SerializeField] private AudioSource targetAudioSource;

    private void Start()
    {
        
        settingsCanvas?.SetActive(false);
        settingsMenuPanel?.SetActive(false);

        
        if (targetAudioSource == null || volumeSlider == null) return;

        volumeSlider.value = targetAudioSource.volume;
        volumeSlider.onValueChanged.AddListener(UpdateVolume);
    }

    public void OpenSettings()
    {
        if (settingsCanvas == null || settingsMenuPanel == null) return;

        settingsCanvas.SetActive(true);
        settingsMenuPanel.SetActive(true);
    }

    public void CloseSettings()
    {
        if (settingsCanvas == null) return;

        settingsCanvas.SetActive(false);
    }

    private void UpdateVolume(float value)
    {
        if (targetAudioSource == null) return;

        targetAudioSource.volume = value;
    }
}
