using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableMusicScript : MonoBehaviour
{
    public Button enableAudioButton;
    public Button disableAudioButton;

    public AudioSource primary_background_music;
    public AudioSource reg_pong_audio;
    public AudioSource split_pong_audio;
    public AudioSource size_pong_audio;
    public AudioSource mult_pong_audio;
    public AudioSource imp_pong_audio;

    private void Start()
    {
        disableAudioButton.gameObject.SetActive(true);
        enableAudioButton.gameObject.SetActive(false);
    }

    public void DisableBackgroundMusic()
    {
        // grab all of the audio sources and disable them
        primary_background_music.volume = 0;
        reg_pong_audio.volume = 0;
        split_pong_audio.volume = 0;
        size_pong_audio.volume = 0;
        mult_pong_audio.volume = 0;
        imp_pong_audio.volume = 0;

        // when clicked, it turns off volume, and disables button that does this
        enableAudioButton.gameObject.SetActive(true);
        disableAudioButton.gameObject.SetActive(false);
    }

    public void EnableBackgroundMusic()
    {
        // grab all of the audio sources and disable them
        primary_background_music.volume = 1;
        reg_pong_audio.volume = 1;
        split_pong_audio.volume = 1;
        size_pong_audio.volume = 1;
        mult_pong_audio.volume = 1;
        imp_pong_audio.volume = 1;

        // when clicked, it turns on volume, and enables button that does this
        disableAudioButton.gameObject.SetActive(true);
        enableAudioButton.gameObject.SetActive(false);
    }
}
