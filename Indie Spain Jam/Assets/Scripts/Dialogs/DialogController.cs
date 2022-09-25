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
        string txt = "Nos hace falta mucha chatarra...";
        canvasGroup = GetComponent<CanvasGroup>();
        txtManager.AddWriter(text, txt, speed);
        Invoke("ToggleInvisibleTxt", timer);
    }

    public void ToggleVisibleTxt()
    {
        CancelInvoke();
        anim.SetBool("Visible", true);
    }
    public void ToggleInvisibleTxt()
    {
        anim.SetBool("Visible", false);
    }

    public void ScreenTxt()
    {
        ToggleVisibleTxt();

        switch (upgrade.quantityUpgrade)
        {
            case 0:
                txtManager.AddWriter(text, "Nos hace falta mucha chatarra...", speed);
                Invoke("ToggleInvisibleTxt", 3);
                break;
            case >= 1:
                if (upgrade.quantityUpgrade >= 9)
                {
                    gameObject.SetActive(false);
                    return;
                }
                if (upgrade.quantityUpgrade < 9)
                    activeTxt();
                break;

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

        Invoke("ToggleInvisibleTxt", timer);
    }
}
