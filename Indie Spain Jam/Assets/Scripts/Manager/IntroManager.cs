using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    [SerializeField] private TxtManager manager;
    [SerializeField] SceneControl sceneControl;
    [SerializeField] string[] txt;
    [SerializeField] private TextMeshProUGUI[] txtContainer;

    private int index;

    private void Start()
    {
        Invoke("showTxt", 1f);
    }

    public void showTxt()
    {
        if (index < txt.Length)
            manager.AddWriter(txtContainer[index], txt[index], 0.08f);
        else
            Invoke("changeScene", 2);
        index++;
        Invoke("showTxt", 5f);
    }

    private void changeScene()
    {
        sceneControl.StartPlaying("GameplayScene");
    }
}
