using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class GlobalNumber : MonoBehaviour
{

    [Header("Txt variables")]
    public TextMeshProUGUI scrapDisplay;
    public TextMeshProUGUI costText;

    [Header("Float variables")]
    public float internalScrap;
    public float upgradeCost;
    [Range(0f, 1f)]
    public float upgradePercentaje;
    public int fase = 1;

    [Header("References")]
    public UpgradeFood upgrade;
    [SerializeField] private Timer gameplayTimer;
    [SerializeField] private SpaceShipAnimController animController;
    [SerializeField] private ButtonAudioController buttonB;
    [SerializeField] private Button buttonBObj;
    [SerializeField] GameVictoryManager victoryManager;


    private void Start()
    {
        UpdateUI();
    }
    public void Contador()
    {
        if (gameplayTimer.canGetScrap)
            internalScrap += 1;
        UpdateUI();
    }

    public void UpdateUI()
    {
        scrapDisplay.text = "Chatarra\n" + internalScrap.ToString("0");
        costText.text = "Siguiente mejora: " + upgradeCost.ToString("0");
    }

    public void UpgradeButton()
    {
        if (internalScrap >= upgradeCost)
        {
            buttonB.playSound();
            upgrade.quantityUpgrade++;
            internalScrap -= upgradeCost;
            upgradeCost += upgradeCost * upgradePercentaje;
            UpdateUI();
            animController.updateAnim(upgrade.quantityUpgrade);
        }

        switch (upgrade.quantityUpgrade)
        {
            case 4:
                fase = 2;
                upgrade.valuePerUpgrade = fase;
                break;
            case 8:
                fase = 3;
                upgrade.valuePerUpgrade = fase;
                costText.gameObject.SetActive(false); 
                break;
            case 9:
                victoryManager.SpecialVictory();
                fase = 4;
                buttonBObj.interactable = false;
                break;

            default:
                return;
        }

    }
}
