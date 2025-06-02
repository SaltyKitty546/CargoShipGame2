using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningMenuReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("Brightness", 1.0f);
        PlayerPrefs.SetFloat("Volume", 1.0f);
        PlayerPrefs.SetInt("ResX", 1920);
        PlayerPrefs.SetInt("ResY", 1080);
        PlayerPrefs.SetInt("QualityLevel", 5);
        PlayerPrefs.SetInt("IsWindowed", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
