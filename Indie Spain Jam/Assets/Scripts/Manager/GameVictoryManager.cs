using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameVictoryManager : MonoBehaviour
{

    [Header("References")]
    [SerializeField] private SpaceShipAnimController animController;
    [SerializeField] private Timer timerController;
    [SerializeField] private UpgradeFood upgradeController;
    [SerializeField] private GlobalNumber ScrapController;

    private int i;

    // Update is called once per frame
    void Update()
    {
        if (!timerController.canGetScrap && i == 0)
        {
            switch (upgradeController.quantityUpgrade)
            {
                case <= 8:
                    debug("lose");
                    break;
                case 9:
                    debug("win");
                    break;
                case >= 10:
                    debug("animal");
                    break;
                default:
                    throw new NotImplementedException();

            }
        }
    }

    private void debug(string obj)
    {
        i++;
        Debug.Log(obj);
    }
}
