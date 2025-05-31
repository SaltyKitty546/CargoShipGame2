using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class GammaSlider : MonoBehaviour
{
    public Slider gammaSlider;
    public float minGamma = 0.1f; // Minimum gamma value
    public float maxGamma = 2.0f; // Maximum gamma value
    public float defaultGamma = 1.0f; // Default gamma value

    void Start()
    {
        // Initialize the slider with the default gamma value
        if (gammaSlider != null)
        {
            gammaSlider.minValue = minGamma;
            gammaSlider.maxValue = maxGamma;
            gammaSlider.value = defaultGamma;
            ApplyGammaCorrection();
        }
        else
        {
            Debug.LogWarning("Gamma slider is not assigned. Make sure to assign it in the Inspector.");
        }
    }

    // Called when the slider value changes
    public void OnValueChanged()
    {
        ApplyGammaCorrection();
    }

    void ApplyGammaCorrection()
    {
        // Adjust gamma correction based on the slider value
        float gamma = gammaSlider.value;
        RenderSettings.ambientLight = new Color(gamma, gamma, gamma, 1.0f); // Make sure gamma mode is enabled in Player Settings
        // You can use RenderSettings.ambientLight, RenderSettings.fog, etc. to adjust other lighting parameters
        // based on the gamma value.
    }
}
