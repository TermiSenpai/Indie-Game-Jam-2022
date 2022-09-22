using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlayer : MonoBehaviour
{
    public GameObject joyBoy;
    public GameObject rawImage;
    public GameObject panel;
    
    public void PlayIntro()
    {
        rawImage.SetActive(true);
        joyBoy.SetActive(true);
        panel.SetActive(false);
    }

}
