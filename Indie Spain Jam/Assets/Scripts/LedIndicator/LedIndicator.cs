using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LedIndicator : MonoBehaviour
{
    public bool isLedOn;

    [SerializeField] private Image ledImage;
    [SerializeField] private Sprite ledOn;
    [SerializeField] private Sprite ledOff;

    private void Start()
    {
        isLedOn = false;
        changeImage();
    }

    public void toggleLed()
    {
        isLedOn = !isLedOn;
        changeImage();
    }

    private void changeImage()
    {
        switch (isLedOn)
        {
            case true:
                ledImage.sprite = ledOn;
                break;
            case false:
                ledImage.sprite = ledOff;
                break;
        }
    }
}
