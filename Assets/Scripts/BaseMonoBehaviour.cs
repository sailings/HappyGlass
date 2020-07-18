using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMonoBehaviour : MonoBehaviour
{
    public void PlayAudioSource(AudioSource audioSource)
    {
        if (audioSource != null && GameState.SoundOn)
            audioSource.Play();
    }

    IEnumerator ExecuteActionIEnum(Action action,float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        action?.Invoke();
    }

    public void ExecuteAction(Action action,float waitTime)
    {
        StartCoroutine(ExecuteActionIEnum(action,waitTime));
    }
}