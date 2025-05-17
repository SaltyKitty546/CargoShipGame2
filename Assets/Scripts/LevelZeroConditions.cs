using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelZeroConditions : MonoBehaviour
{
    // Start is called before the first frame update
    public SaveTheData sd;
    public PlayerHealthControl phc;
    public Inventory i;

    void Start()
    {
        LoadZero();
        PlayerPrefs.SetInt("underworldProgression", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadZero()
    {
        i.haveRedKeycard = false;
        i.haveBlueKeycard = false;
        i.haveGreenKeycard = false;
        phc.health = 100;
        phc.hungerLevel = 10;
        i.crowbars = 0;
        i.radios = 0;
        i.flashbangs = 0;
        i.flareguns = 0;

        sd.SavingData();
    }
}
