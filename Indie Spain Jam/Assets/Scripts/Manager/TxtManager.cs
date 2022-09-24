using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TxtManager : MonoBehaviour
{
    TextMeshProUGUI uiTxt;
    string txtToWrite;
    float timePerCharacter;
    float timer;
    int charIndex;


    public void AddWriter(TextMeshProUGUI uiTxt, string txtToWrite, float timePerChar)
    {
        this.uiTxt = uiTxt;
        this.txtToWrite = txtToWrite;
        this.timePerCharacter = timePerChar;
        charIndex = 0;
    }

    private void Update()
    {
        if(uiTxt != null)
        {
            timer -= Time.deltaTime;
            while(timer <= 0f)
            {
                timer += timePerCharacter;
                charIndex++;
                uiTxt.text = txtToWrite.Substring(0, charIndex);

                if(charIndex >= txtToWrite.Length)
                {
                    uiTxt = null;
                    return;
                }
            }
        }
    }
}
