using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor;
using UnityEngine;

public class GameVictoryManager : MonoBehaviour
{

    [Header("References")]
    [SerializeField] private SpaceShipAnimController animController;
    [SerializeField] private Timer timerController;
    [SerializeField] private UpgradeFood upgradeController;
    [SerializeField] private GlobalNumber ScrapController;
    [SerializeField] private SceneControl scene;
    [SerializeField] private EndingController ending;

    [Header("Endings")]
    [SerializeField] private GameObject badEnding;
    [SerializeField] private GameObject goodEnding;
    [SerializeField] private GameObject specialEnding;

    [Header("Audio")]
    [SerializeField] private AudioSource endingAudioPlayer;
    [SerializeField] private AudioSource soundtrackAudioPlayer;
    [SerializeField] private AudioClip badEndingClip;
    [SerializeField] private AudioClip goodEndingClip;
    [SerializeField] private AudioClip specialEndingClip;

    [Header("animator")]
    [SerializeField] private Animator fundido;

    [Header("GameObjects")]
    [SerializeField] private GameObject txtContainter;

    private int i;

    // Update is called once per frame
    void Update()
    {
        if (!timerController.canGetScrap && i == 0)
        {
            switch (upgradeController.quantityUpgrade)
            {
                case <= 7:
                    badEnding.SetActive(true);
                    playEndingSound(badEndingClip);
                    debug("lose");
                    ending.showBadEnding();
                    break;

                case 8:
                    goodEnding.SetActive(true);
                    playEndingSound(goodEndingClip);
                    debug("win");
                    ending.showGoodending();
                    break;
                case >= 9:

                    playEndingSound(specialEndingClip);
                    specialEnding.SetActive(true);
                    debug("animal");
                    ending.showSpecialEnding();
                    break;
                default:
                    throw new NotImplementedException();

            }

            PlayerPrefs.SetFloat("total", ScrapController.totalScrap);

            ScrapController.costText.gameObject.SetActive(false);
            ScrapController.scrapDisplay.gameObject.SetActive(false);
            txtContainter.SetActive(false);
            Invoke("startBlackScreen", 10f);
            Invoke("changeScene", 20);
        }
    }

    public void SpecialVictory()
    {
        timerController.MusicTimer = 1.0f;   
    }

    private void debug(string txt)
    {
        i++;
        Debug.Log(txt);
    }

    private void playEndingSound(AudioClip clip)
    {
        soundtrackAudioPlayer.Stop();
        endingAudioPlayer.PlayOneShot(clip);
    }

    private void startBlackScreen()
    {
        fundido.SetTrigger("Finish");
    }

    private void changeScene()
    {
        scene.recordScene();
    }
}
