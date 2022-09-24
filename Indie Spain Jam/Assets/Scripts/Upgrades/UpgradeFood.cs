using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeFood : MonoBehaviour
{
    public float waitTime;
    public float valuePerUpgrade;
    public int quantityUpgrade;
    public GlobalNumber UI;

    
  
    void Start()
    {
        InvokeRepeating("Passive", 1, waitTime);
    }

    public void Passive()
    {

        if (quantityUpgrade > 0)
        {
            UI.internalScrap += valuePerUpgrade * quantityUpgrade;
            UI.UpdateUI();
        }
    }

}
