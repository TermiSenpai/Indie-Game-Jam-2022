using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudioController : MonoBehaviour
{
    private AudioSource buttonSound;
    [SerializeField] private AudioClip clip;

    private void Start()
    {
        buttonSound = GetComponent<AudioSource>();
    }

    public void playSound()
    {
        buttonSound.PlayOneShot(clip);
    }
}
