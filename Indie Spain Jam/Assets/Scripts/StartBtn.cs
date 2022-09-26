using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBtn : MonoBehaviour
{
    public GameObject StartUI;
    public bool canExitGame;

    private void Start()
    {
        StartUI.SetActive(false);
        canExitGame = false;
    }

    public void toggleStartMenu()
    {
        StartUI.SetActive(!StartUI.activeInHierarchy);
        canExitGame = !canExitGame;
        Time.timeScale = canExitGame ? 0 : 1;

        AudioSource[] audios = FindObjectsOfType<AudioSource>();

        foreach (AudioSource audio in audios)
        {
            if (canExitGame)
                audio.Pause();
            else
                audio.Play();
        }
    }
}
