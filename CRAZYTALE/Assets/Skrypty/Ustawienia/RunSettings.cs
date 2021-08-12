using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RunSettings : MonoBehaviour
{
    public AudioMixer mixer;
    // Start is called before the first frame update
    void Start()
    {
        mixer.SetFloat("vol", PlayerPrefs.GetFloat("volume"));
        QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("quality"));
    }
}
