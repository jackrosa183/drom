using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioTimer : MonoBehaviour
{
    bool okayToPlayAudio;
    public float timeLeft = 10f; //time in seconds
    public AudioSource theaterVoice;
    public AudioClip audioClip;
    public void Update()
    {

        if (timeLeft > 0.0)
        {

            timeLeft -= Time.deltaTime;


        }
        else
        {

            okayToPlayAudio = true;

        }
        if (okayToPlayAudio)
        {

            theaterVoice.PlayOneShot(audioClip, 1.0f);
            okayToPlayAudio = false;
            timeLeft = 10.0f;
            Destroy(gameObject, 5);
        }

    }
}

