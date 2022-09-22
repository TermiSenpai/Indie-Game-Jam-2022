<<<<<<< Updated upstream
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class GlobalNumber : MonoBehaviour
{

    
    public TextMeshProUGUI scrapDisplay;
    public float internalScrap;
    public float upgradeCost;
    public UpgradeFood upgrade;
    public TextMeshProUGUI costText;
    [Range(0f, 1f)]
    public float upgradePercentaje;


    private void Start()
    {
        UpdateUI();
    }
    public void Contador()
    {
        internalScrap +=1;
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
    public void ApagarConsola(string sceneName)
    {
        SceneManager.LoadScene(sceneName); 
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class GlobalNumber : MonoBehaviour
{

    
    public TextMeshProUGUI scrapDisplay;
    public float internalScrap;
    public float upgradeCost;
    public UpgradeFood upgrade;
    public TextMeshProUGUI costText;
    [Range(0f, 1f)]
    public float upgradePercentaje;


    private void Start()
    {
        UpdateUI();
    }
    public void Contador()
    {
        internalScrap +=1;
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
    public void ApagarConsola(string sceneName)
    {
        SceneManager.LoadScene(sceneName); 
    }
}
>>>>>>> Stashed changes
