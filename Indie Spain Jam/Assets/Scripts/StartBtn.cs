using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StartBtn : MonoBehaviour
{
    public GameObject StartUI;
    public bool canExitGame;
    public bool[] playing;
    public int index;

    private void Start()
    {
        StartUI.SetActive(false);
        canExitGame = false;
    }

    public void toggleStartMenu()
    {
        index = 0;
        StartUI.SetActive(!StartUI.activeInHierarchy);
        canExitGame = !canExitGame;
        Time.timeScale = canExitGame ? 0 : 1;

        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        playing = new bool [audios.Count()];

        foreach (AudioSource audio in audios)
        {
            if (canExitGame)
            {
                playing[index] = audio.isPlaying;
                audio.Pause();
            }
            else
            {
                    audio.Play();
            }
            index++;
        }
    }
}
