using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showTutorial : MonoBehaviour
{
    [SerializeField] private GameObject tutorial;

    public void toggleTutorial()
    {
        tutorial.SetActive(!tutorial.activeInHierarchy);
    }
}
