using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource defaultAudio;
    public bool defaultAudioLoop;

    public void Start ()
    {
        if (defaultAudio != null)
        {
            playAudio(defaultAudio, defaultAudioLoop);
        }
    }

    public void playAudio (AudioSource audio, bool loop)
    {
        if (loop)
        {
            audio.Play();
        } else
        {
            audio.PlayOneShot(audio.clip);
        }
    }
}
