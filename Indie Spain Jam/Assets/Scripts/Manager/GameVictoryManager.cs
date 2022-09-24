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

    [Header("Endings")]
    [SerializeField] private GameObject badEnding;
    [SerializeField] private GameObject goodEnding;
    [SerializeField] private GameObject specialEnding;

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
                    debug("lose");
                    break;
                case 8:
                    goodEnding.SetActive(true);
                    debug("win");
                    break;
                case >= 9:
                    specialEnding.SetActive(true);
                    debug("animal");
                    break;
                default:
                    throw new NotImplementedException();

            }
            ScrapController.costText.gameObject.SetActive(false);
            ScrapController.scrapDisplay.gameObject.SetActive(false);
        }
    }

    private void debug(string txt)
    {
        i++;
        Debug.Log(txt);
    }
}
