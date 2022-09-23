using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSliderManager : MonoBehaviour
{
    public VolumeSliderManager instance;
    public Slider slider;

    private float audioPref;

    [SerializeField] private AudioMixer mixer;
    [SerializeField] private string volumeName;



    private void Awake()
    {
        if (instance == null)        
            instance = this;        
        else
            Destroy(gameObject);

        if (PlayerPrefs.HasKey("sliderValue"))
        {           
            slider.value = PlayerPrefs.GetFloat("sliderValue");
        }
    }

    public void SetVolume(float sliderValue)
    {
        mixer.SetFloat(volumeName, Mathf.Log10(sliderValue) * 20);
        

        PlayerPrefs.SetFloat("sliderValue",sliderValue);
    }
}
