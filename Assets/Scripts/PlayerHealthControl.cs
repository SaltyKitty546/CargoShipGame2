using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms;
using UnityEngine.SceneManagement;

public class PlayerHealthControl : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public int hungerLevel;
    public int hungerCooldown;
    public int hungerCooldownMax;
    private int hungerLevelDecreaseBuff;
    public TMP_Text healthText;
    public TMP_Text hungerText;
    public GameObject gameOver;
    public SaveTheData sd;
    



    void Start()
    {
        //Hunger
        hungerCooldown = hungerCooldownMax;
        hungerLevelDecreaseBuff = 50;
        gameOver.SetActive(false);
        sd.LoadData();
        Time.timeScale = 1.0f;
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Health
        string healthTextWords = health.ToString();
        healthText.text = healthTextWords;

        if (health < 1)
        {
            health = 0;
            GameOver();
        }
        if (health > 100)
        {
            health = 100;
        }

        //Hunger
        string hungerTextWords = hungerLevel.ToString();
        hungerText.text = hungerTextWords;

        if (hungerLevel < 1)
        {
            hungerLevel = 0;
            GameOver();
            

        } else if (hungerLevel > 10) 
        {
            hungerCooldown = 10;
        }  
        if (hungerCooldown < 1)
        {
            hungerLevel -= 1;
            hungerCooldown = hungerCooldownMax;
            if (hungerLevel < 5)
            {
                hungerCooldown += hungerLevelDecreaseBuff;
            }
        } else
        {
            hungerCooldown -= 1;
        }

    }

    void GameOver()
    {
        Debug.Log("You died");
        int underworld = PlayerPrefs.GetInt("underworldProgression");
        
        
        if (underworld == 0) {
            underworld += 1;
            PlayerPrefs.SetInt("underworldProgression", underworld);
            SceneManager.LoadScene("Underworld");
        } else {
            Time.timeScale = 0.1f;
            gameOver.SetActive(true);
        }
    }
}
