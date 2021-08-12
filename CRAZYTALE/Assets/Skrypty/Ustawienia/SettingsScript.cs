using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsScript : MonoBehaviour
{
    public AudioMixer mixer;
    private float volume;
    private int quality;
    public void SetVolume(float x)
    {
        volume = x;
        mixer.SetFloat("vol", x);
    }

    public void SetQuality(int d)
    {
        quality = d;
        QualitySettings.SetQualityLevel(d);
    }
    public void SaveAndExit()
    {
        PlayerPrefs.SetFloat("volume", volume);
        PlayerPrefs.SetInt("quality", quality);
        ExitSettings();
    }
    public void ExitSettings()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

}
