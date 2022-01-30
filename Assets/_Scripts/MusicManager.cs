using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicManager : MonoBehaviour
{
    public AudioClip soundtrack;
    
    AudioSource audioSource;

    private void Start()
    {
        audioSource.GetComponent<AudioSource>();
        audioSource.playOnAwake = true;
        audioSource.loop = true;
        audioSource.PlayOneShot(soundtrack);
    }

}
