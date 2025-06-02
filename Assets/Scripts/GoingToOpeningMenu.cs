using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoingToOpeningMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var go = PlayerPrefs.GetInt("GoingToOpeningMenu");
        print(go);
        
        
        if (go == 1)
        {
            Screen.SetResolution(PlayerPrefs.GetInt("ResX"), PlayerPrefs.GetInt("ResY"), true);
            QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("QualityLevel"), true);
            SceneManager.LoadScene("Menu");
        } else
        {
            go = 1;
            PlayerPrefs.SetInt("GoingToOpeningMenu", go);
            SceneManager.LoadScene("OpeningMenu");
            
        }
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
