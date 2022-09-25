using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class DialogController : MonoBehaviour
{
    public float speed;
    public string[] capitan;
    public string[] random;

    private CanvasGroup canvasGroup;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TxtManager txtManager;
    [SerializeField] private UpgradeFood upgrade;
    [SerializeField] private Animator anim;
    [SerializeField] private float timer;

    private void Start()
    {
        string txt = "A conseguir chatarra!";
        canvasGroup = GetComponent<CanvasGroup>();
        txtManager.AddWriter(text, txt, speed);
        Invoke("toggleTxtBox", 3);
    }

    public void toggleTxtBox()
    {
        anim.SetBool("Visible", !anim.GetBool("Visible"));
    }

    public void ScreenTxt()
    {
        toggleTxtBox();

        switch (upgrade.quantityUpgrade)
        {
            case 0:
                txtManager.AddWriter(text, "A conseguir chatarra!", speed);
                Invoke("toggleTxtBox", 3);
                break;
            case >= 1:
                if (upgrade.quantityUpgrade == 9)
                    gameObject.SetActive(false);
                activeTxt();
                break;
            //case 2:
            //    activeTxt();
            //    break;
            //case 3:
            //    activeTxt();
            //    break;
            //case 4:
            //    activeTxt();
            //    break;
            //case 5:
            //    activeTxt();
            //    break;
            //case 6:
            //    activeTxt();
            //    break;
            //case 7:
            //    activeTxt();
            //    break;
            //case 8:
            //    activeTxt();
            //    break;


            default:
                Debug.Log("algo salió mal");
                break;
        }
    }

    private void activeTxt()
    {
        capitanTxt();
        Invoke("conver", timer);
    }

    private void capitanTxt()
    {
        txtManager.AddWriter(text, capitan[upgrade.quantityUpgrade - 1], speed);
    }

    private void conver()
    {
        txtManager.AddWriter(text, random[upgrade.quantityUpgrade - 1], speed);

        Invoke("toggleTxtBox", timer);
    }
}
