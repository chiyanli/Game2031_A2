using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioSource sfxSource;
    public AudioSource musicSource; // For background music

    public AudioClip jumpSFX;
    public AudioClip backgroundMusic;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // Play background music on start
        PlayBackgroundMusic();
    }

    public void PlayJumpSound()
    {
        if (jumpSFX != null && sfxSource != null)
            sfxSource.PlayOneShot(jumpSFX);
    }

    public void PlayBackgroundMusic()
    {
        if (musicSource != null && backgroundMusic != null)
        {
            musicSource.clip = backgroundMusic;
            musicSource.loop = true;
            musicSource.Play();
        }
    }
}
