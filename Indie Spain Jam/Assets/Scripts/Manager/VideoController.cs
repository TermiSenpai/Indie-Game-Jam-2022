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

    [SerializeField] private SceneControl sceneControl;
    [SerializeField] private float timeToChangeScene;


    public void videoStart()
    {
        Invoke("blackScreenOff", time);
        Invoke("FinishVideo", 6);
        Invoke("changeScene", timeToChangeScene);
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

    private void changeScene()
    {
        sceneControl.StartPlaying("GameplayScene");
    }



}

