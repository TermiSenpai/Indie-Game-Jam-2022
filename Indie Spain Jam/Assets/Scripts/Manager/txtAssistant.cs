using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class txtAssistant : MonoBehaviour
{
    [SerializeField] private TxtManager txtManager;
    [SerializeField] private string[] writeTxt;
    [SerializeField] TextMeshProUGUI txt;


    private void Start()
    {
       // txtManager.AddWriter(txt, writeTxt[0], 0.1f);
    }
}
