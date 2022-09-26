using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public StartBtn startBtn;

    public void ApagarConsola(string scene)
    {
        if (!startBtn.canExitGame)
            SceneManager.LoadScene(scene);
        else
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    public void StartPlaying(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void recordScene()
    {
        SceneManager.LoadScene("PointsScene");
    }
}
