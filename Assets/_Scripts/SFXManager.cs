using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioClip chestOpen;

    AudioSource audioSource;

    private void Start()
    {
        audioSource.GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.loop = false;
    }

    public void ChestSFX()
    {
        audioSource.PlayOneShot(chestOpen);
    }
}
