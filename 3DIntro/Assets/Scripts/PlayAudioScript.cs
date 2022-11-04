using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioScript : MonoBehaviour
{

    public AudioSource myAudioSource;

    public void PlayMyself()
    {
        if (!myAudioSource.isPlaying){
        myAudioSource.Play();
        }
    }

    public void ShutMyselfUp(){
        if (myAudioSource.isPlaying){
        myAudioSource.Stop();
        }
    }
}
