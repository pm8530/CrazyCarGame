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
        if(PlayerPrefs.HasKey("musicVolume"))
        VolumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
        else
        {
            VolumeSlider.value = VolumeSlider.maxValue;
        }
    }


    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", VolumeSlider.value);
    }

    [ContextMenu("Delete All Data")]
    public void DeleteAllSaveData()
    {
        PlayerPrefs.DeleteAll();
    }
}
