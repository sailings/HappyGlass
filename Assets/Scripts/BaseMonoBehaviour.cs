using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMonoBehaviour : MonoBehaviour
{
    public void PlayAudioSource(AudioSource audioSource)
    {
        if (audioSource != null)
            audioSource.Play();
    }
}