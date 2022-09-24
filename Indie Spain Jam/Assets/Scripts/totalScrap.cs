using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class totalScrap : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI valueTxt;
    [SerializeField] CanvasGroup restartTxt;
    public float speed;
    public float speed2;
    float value;
    float increaseScore = 0;


    private void Start()
    {
        value = PlayerPrefs.GetFloat("total");        
    }

    private void Update()
    {
        if (increaseScore <= value)
        {
            increaseScore += Time.deltaTime * speed;
            valueTxt.text = increaseScore.ToString("0");
        }
        else
        {             
            if(restartTxt.alpha <= 1)
            {
                restartTxt.alpha += Time.deltaTime * speed2;
            }

        }

    }
}
