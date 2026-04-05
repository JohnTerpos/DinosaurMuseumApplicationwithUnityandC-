using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Audio : MonoBehaviour
{


    public AudioSource sound;
    public void StartAudio()
    {
        sound.Play();
    }
}
