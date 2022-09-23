using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCiontrol : MonoBehaviour
{
    public void ApagarConsola(Scene scene)
    {
        SceneManager.LoadScene(scene.name);
    }

    public void StartPlaying(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
