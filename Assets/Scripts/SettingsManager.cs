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
    public GameObject settingsCanvas;          
    public GameObject settingsMenuPanel;       
    public Slider volumeSlider;                

    [Header("Audio")]
    public AudioSource targetAudioSource;      

    private void Start()
    {
       
        if (settingsCanvas != null)
            settingsCanvas.SetActive(false);

        if (settingsMenuPanel != null)
            settingsMenuPanel.SetActive(false);

     
        if (targetAudioSource != null && volumeSlider != null)
        {
            volumeSlider.value = targetAudioSource.volume;
            volumeSlider.onValueChanged.AddListener(UpdateVolume);
        }
    }

    
    public void OpenSettings()
    {
        if (settingsCanvas != null)
            settingsCanvas.SetActive(true);

        if (settingsMenuPanel != null)
            settingsMenuPanel.SetActive(true);
    }

   
    public void CloseSettings()
    {
        if (settingsCanvas != null)
            settingsCanvas.SetActive(false);
    }

   
    private void UpdateVolume(float value)
    {
        if (targetAudioSource != null)
            targetAudioSource.volume = value;
    }
}
