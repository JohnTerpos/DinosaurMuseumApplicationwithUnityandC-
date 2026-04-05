using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class video_trigger : MonoBehaviour
{

    public GameObject video_object;
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            video_object.GetComponent<VideoPlayer>().Play();
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            video_object.GetComponent<VideoPlayer>().Stop();
        }
    }
}
