using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audio;

    public void SetVolume(float volume)
    {
        audio.SetFloat("Volume", volume);
    }
}
