using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControler : MonoBehaviour
{



    public Slider VolumeSlider;
    private void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 10);
            Load();
        }
        else
        {
            Load();
        }
    }


    public void ChangeVolume()
    {
        AudioListener.volume = VolumeSlider.value;
        Save();
    }
    
    public void Load()
    {
        VolumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }


    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", VolumeSlider.value);
    }

}
