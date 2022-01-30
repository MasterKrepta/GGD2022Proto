using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupMusicManager : MonoBehaviour
{
    public AudioClip pickupMusic;

    AudioSource audioSource;

    private void Start()
    {
        audioSource.GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.loop = false;
    }

    public void PickupMusic()
    {
        audioSource.PlayOneShot(pickupMusic);
    }
}
