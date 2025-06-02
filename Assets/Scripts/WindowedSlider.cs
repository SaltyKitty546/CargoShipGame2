using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowedSlider : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider windowedSlider;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (windowedSlider.value == 1)
        {
            PlayerPrefs.SetInt("IsWindowed", 1);
        } else
        {
            PlayerPrefs.SetInt("IsWindowed", 0);
        }
    }
}
