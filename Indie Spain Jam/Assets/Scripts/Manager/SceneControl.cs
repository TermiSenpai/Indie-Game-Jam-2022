using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void ApagarConsola(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void StartPlaying(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
