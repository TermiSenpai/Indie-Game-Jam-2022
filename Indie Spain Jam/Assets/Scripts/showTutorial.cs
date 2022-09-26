using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showTutorial : MonoBehaviour
{
    [SerializeField] private GameObject tutorial;
    [SerializeField]
    VideoController videoController;

    public void toggleTutorial()
    {
        if (videoController.pulse != 0)
            tutorial.SetActive(!tutorial.activeInHierarchy);
    }
}
