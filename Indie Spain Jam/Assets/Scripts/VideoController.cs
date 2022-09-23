using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{

    [SerializeField] private VideoPlayer video;
    [SerializeField] private GameObject VideoObj;
    [SerializeField] private GameObject blackScreen;
    [SerializeField] private float time;


    public void videoStart()
    {
        Invoke("blackScreenOff", time);
        Invoke("FinishVideo", 6);
        video.Play();
    }

    private void blackScreenOff()
    {
        blackScreen.SetActive(false);
    }

    private void FinishVideo()
    {
        VideoObj.SetActive(false);
    }



}

