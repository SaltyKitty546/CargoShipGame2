using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider volumeSlider;
    public float volume;

    void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("Volume");
    }

    // Update is called once per frame
    void Update()
    {
        volume = volumeSlider.value;
        PlayerPrefs.SetFloat("Volume", volume);
    }
}
