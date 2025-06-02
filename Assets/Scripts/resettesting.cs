using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resettesting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("GoingToOpeningMenu", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
