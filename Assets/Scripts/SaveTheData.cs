using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveTheData : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayerHealthControl aphc;
    public Inventory i;

    public int redKey;
    public int greenKey;
    public int blueKey;

    public int currentLevel;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelChecking()
    {
        var currentScene = SceneManager.GetActiveScene();
        var currentSceneName = currentScene.name;
        if (currentSceneName == "Level0Part1")
        {
            currentLevel = 0;
        }
        if (currentSceneName == "Level0Part2")
        {
            currentLevel = 1;
        }
        if (currentSceneName == "Level1Part1")
        {
            currentLevel = 2;
        }
        if (currentSceneName == "Level1Part2")
        {
            currentLevel = 3;
        }
        if (currentSceneName == "Level1Part3")
        {
            currentLevel = 4;
        }
        if (currentSceneName == "Level2Part1")
        {
            currentLevel = 5;
        }
        if (currentSceneName == "Level2Part2")
        {
            currentLevel = 6;
        }
        if (currentSceneName == "Level2Part3")
        {
            currentLevel = 7;
        }
        if (currentSceneName == "Level2Part4")
        {
            currentLevel = 8;
        }
        if (currentSceneName == "Level2Part5")
        {
            currentLevel = 9;
        }
        if (currentSceneName == "Level2Part6")
        {
            currentLevel = 10;
        }
        if (currentSceneName == "Level2Part7")
        {
            currentLevel = 11;
        }
        if (currentSceneName == "Level3Part1")
        {
            currentLevel = 12;
        }
        if (currentSceneName == "Level3Part2")
        {
            currentLevel = 13;
        }
        if (currentSceneName == "Level3Part3")
        {
            currentLevel = 14;
        }
        if (currentSceneName == "Level3Part4")
        {
            currentLevel = 15;
        }
        if (currentSceneName == "LevelF")
        {
            currentLevel = 16;
        }


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

        PlayerPrefs.SetInt("Radios", i.radios);
        PlayerPrefs.SetInt("Flareguns", i.flareguns);
        PlayerPrefs.SetInt("Flashbangs", i.flashbangs);

        PlayerPrefs.SetInt("RedKey", redKey);
        PlayerPrefs.SetInt("BlueKey", blueKey);
        PlayerPrefs.SetInt("GreenKey", greenKey);

        LevelChecking();
        PlayerPrefs.SetInt("CurrentLevel", currentLevel);
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

        i.radios = PlayerPrefs.GetInt("Radios");
        i.flareguns = PlayerPrefs.GetInt("Flareguns");
        i.flashbangs = PlayerPrefs.GetInt("Flashbangs");

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
