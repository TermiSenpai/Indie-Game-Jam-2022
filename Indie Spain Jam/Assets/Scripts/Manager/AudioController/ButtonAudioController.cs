using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudioController : MonoBehaviour
{
    private AudioSource buttonSound;
    [SerializeField] private AudioClip clip;
    [SerializeField] private UpgradeFood upgrade;

    private void Start()
    {
        buttonSound = GetComponent<AudioSource>();
    }

    public void playSound()
    {
        buttonSound.PlayOneShot(clip);
    }

    public void playDelaySound(float delay)
    {
        buttonSound.PlayDelayed(delay);
    }

    public void playUpgradeSound()
    {
        if (upgrade.quantityUpgrade <= 7)
            buttonSound.PlayOneShot(clip);
    }
}
