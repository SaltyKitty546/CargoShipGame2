using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class GammaSlider : MonoBehaviour
{
    // Start is called before the first frame update
    public float gamma;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.ambientLight = new Color(gamma, gamma, gamma, 1.0f);
    }
}
