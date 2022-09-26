using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class EndingController : MonoBehaviour
{
    [SerializeField] private TxtManager txtManager;

    [SerializeField] private TextMeshProUGUI txtComponent;
    [SerializeField] private string[] badEndTxt;
    [SerializeField] private string[] goodEndTxt;
    [SerializeField] private string[] specialEndTxt;

    private int index;
    public void showBadEnding()
    {
        if (index < badEndTxt.Length)
            txtManager.AddWriter(txtComponent, badEndTxt[index], 0.05f);
        index++;
        Invoke("showBadEnding", 6.5f);
    }
    public void showGoodending()
    {
        if (index < badEndTxt.Length)
            txtManager.AddWriter(txtComponent, goodEndTxt[index], 0.05f);
        index++;
        Invoke("showGoodending", 6.5f);
    }
    public void showSpecialEnding()
    {
        if (index < badEndTxt.Length)
            txtManager.AddWriter(txtComponent, specialEndTxt[index], 0.05f);
        index++;
        Invoke("showSpecialEnding", 6.5f);
    }
}
