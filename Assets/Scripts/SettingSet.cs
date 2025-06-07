using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;

public class SettingSet : MonoBehaviour
{
    // Start is called before the first frame update
    public Light l;
    public Light[] lights;
    public bool isSettingMenu;
    

    void Start()
    {
        /*lights = gameObject.FindObjectsByType<Light>();
        for(int i = 0; i < lights; i++) 
        {
            lights.intensity[i] = lights.intensity[i] * PlayerPrefs.GetFloat("Brightness");
        }
        */
        
    }

    // Update is called once per frame
    void Update()
    {
        l.intensity = PlayerPrefs.GetFloat("Brightness");
        AudioListener.volume = PlayerPrefs.GetFloat("Volume");
        
    }
}
