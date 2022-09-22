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

    [Header("References")]
    public UpgradeFood upgrade;
    [SerializeField] private Timer gameplayTimer;


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
            upgrade.quantityUpgrade++;
            internalScrap -= upgradeCost;
            upgradeCost += upgradeCost * upgradePercentaje;
            UpdateUI();
        }
    }
}
