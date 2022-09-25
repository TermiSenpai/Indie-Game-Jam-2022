using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDialogController : MonoBehaviour
{
    [SerializeField] private Button buttonB;
    [SerializeField] private float timer;

    public void upgradeTimer()
    {
        buttonB.interactable = false;
        Invoke("activateButton", timer);
    }

    private void activateButton()
    {
        buttonB.interactable = true;
    }
}
