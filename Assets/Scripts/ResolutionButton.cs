using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionButton : MonoBehaviour
{
    // Start is called before the first frame update
    public int res1;
    public int res2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRes()
    {
        var a = PlayerPrefs.GetInt("IsWindowed");
        if (a == 1)
        {
            Screen.SetResolution(res1, res2, false);
        } else
        {
            Screen.SetResolution(res1, res2, true);
        }
        PlayerPrefs.SetInt("ResX", res1);
        PlayerPrefs.SetInt("ResY", res2); 
    }
}
