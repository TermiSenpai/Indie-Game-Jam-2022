using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerController : MonoBehaviour
{
    [SerializeField] AudioMixerGroup mixer;
    private AudioSource[] sources;

    private void Start()
    {
        sources = FindObjectsOfType<AudioSource>();

        foreach(AudioSource source in sources)
        {
            source.outputAudioMixerGroup = mixer;
        }
    }
}
