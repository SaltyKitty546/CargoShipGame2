using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveTheData : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayerHealthControl aphc;
    public Inventory i;

    public int redKey;
    public int greenKey;
    public int blueKey;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SavingData()
    {
        if (i.haveRedKeycard == true)
        {
            redKey = 1;
        } else
        {
            redKey = 0;
        }

        if (i.haveGreenKeycard == true)
        {
            greenKey = 1;
        }
        else
        {
            greenKey = 0;
        }

        if (i.haveBlueKeycard == true)
        {
            blueKey = 1;
        }
        else
        {
            blueKey = 0;
        }

        PlayerPrefs.SetInt("Health", aphc.health);
        PlayerPrefs.SetInt("Hunger", aphc.hungerLevel);
        PlayerPrefs.SetInt("Crowbars", i.crowbars);
        
        PlayerPrefs.SetInt("RedKey", redKey);
        PlayerPrefs.SetInt("BlueKey", blueKey);
        PlayerPrefs.SetInt("GreenKey", greenKey);
        Debug.Log("health" + PlayerPrefs.GetInt("Health"));

    }

    public void LoadData()
    {
        aphc.health = PlayerPrefs.GetInt("Health");
        aphc.hungerLevel = PlayerPrefs.GetInt("Hunger");
        i.crowbars = PlayerPrefs.GetInt("Crowbars");
        redKey = PlayerPrefs.GetInt("RedKey");
        greenKey = PlayerPrefs.GetInt("GreenKey");
        blueKey = PlayerPrefs.GetInt("BlueKey");

        if (redKey == 1)
        {
            i.haveRedKeycard = true;
        } else
        {
            i.haveRedKeycard = false;
        }
        if (greenKey == 1)
        {
            i.haveGreenKeycard = true;
        }
        else
        {
            i.haveGreenKeycard = false;
        }
        if (blueKey == 1)
        {
            i.haveBlueKeycard = true;
        }
        else
        {
            i.haveBlueKeycard = false;
        }
        Debug.Log("health" + PlayerPrefs.GetInt("Health"));


    }
}
