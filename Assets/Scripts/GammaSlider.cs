using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class GammaSlider : MonoBehaviour
{
    public Slider gammaSlider;
    public float brightness;

    public void Start()
    {
        gammaSlider.value = PlayerPrefs.GetFloat("Brightness");
    }
    public void Update()
    {
        
        brightness = gammaSlider.value;
        PlayerPrefs.SetFloat("Brightness", brightness);
    }

    
}
