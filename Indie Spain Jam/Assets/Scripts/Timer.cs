using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [Tooltip("Tiempo que dura la canción en segundos")]
    [SerializeField] private float MusicTimer;

    public bool canGetScrap { get; private set; }

    private void Start()
    {
        canGetScrap = true;
    }

    private void Update()
    {

        if (MusicTimer <= 0 && canGetScrap)
            canGetScrap = false;
        else
            MusicTimer -= Time.deltaTime;

    }
}
