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
    private TextMeshProUGUI TextoMejoras;

    private void Awake()
    {
        TextoMejoras = FindObjectOfType<TextMeshProUGUI>();
    }

    private void Start()
    {
        //txtManager.AddWriter(TextoMejoras, writeTxt[0], 0.1f);
        //TextoMejoras.SetText("Hola Caracola");
        //TextoMejoras.text = "Arriba chuta la victoria es tuya";
    }

    void MejoraMaquina()
    {
        
        txtManager.AddWriter(TextoMejoras, writeTxt[0], 0.1f);
    }
}
