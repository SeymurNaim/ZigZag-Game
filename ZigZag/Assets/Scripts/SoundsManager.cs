using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager : MonoBehaviour
{
    public static SoundsManager instance;
    AudioSource source;
    public AudioClip[] audioClips;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

    void Start()
    {
        source = GetComponent<AudioSource>();
    }


    public void ClickSound()
    {
        source.clip = audioClips[0];
        source.Play();
    }

    public void GameOver()
    {
        source.PlayOneShot(audioClips[1]);

    }
    
}
