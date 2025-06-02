using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;

public class SettingSet : MonoBehaviour
{
    // Start is called before the first frame update
    public Light l;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        
        
         l.intensity = PlayerPrefs.GetFloat("Brightness");
         AudioListener.volume = PlayerPrefs.GetFloat("Volume");
            
        
    }
}
