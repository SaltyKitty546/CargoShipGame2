using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QualityButton : MonoBehaviour
{
    // Start is called before the first frame update
    public int q;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetQualityLevel()
    {
        PlayerPrefs.SetInt("QualityLevel", q);
        QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("QualityLevel"), true);
    }
}
