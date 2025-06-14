using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class SettingSet : MonoBehaviour
{
    // Start is called before the first frame update
    public Light l;
    public Light[] lights;
    public bool isSettingMenu;

    private float pastValue;
    private float brightness;
    

    void Start()
    {
        lights = FindObjectsOfType<Light>();
        pastValue = PlayerPrefs.GetFloat("Brightness");

        for(int i = 0; i < lights.Length; i++) 
        {
            float lightIntensity = lights[i].intensity;
            lights[i].intensity = lightIntensity * PlayerPrefs.GetFloat("Brightness");
        }
    
        
    }

    // Update is called once per frame
    void Update()
    {
        l.intensity = PlayerPrefs.GetFloat("Brightness");
        AudioListener.volume = PlayerPrefs.GetFloat("Volume");
        brightness = PlayerPrefs.GetFloat("Brightness");

        if (pastValue != brightness && isSettingMenu) {
            float diff = brightness - pastValue;
            if (diff < -0.2 || diff > 0.2) {
                string currentSceneName = SceneManager.GetActiveScene().name;
                pastValue = brightness;
                SceneManager.LoadScene(currentSceneName);
            }
        }

    }

    
}
