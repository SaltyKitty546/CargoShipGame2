using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    // Start is called before the first frame update
    public bool inUnderworld;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e")) {
            if (inUnderworld) {
                GoBackToLevel();
            } else {
                RetryLevel();
            }
        }

        if (Input.GetKeyDown("c")) {
            BackToMenu();
        }
    }

    public void RetryLevel()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void BackToMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }

    public void GoBackToLevel() {
        int level = PlayerPrefs.GetInt("CurrentLevel");
        Time.timeScale = 1.0f;
        if (level == 0)
        {
            SceneManager.LoadScene("Level0Part1");
        }
        if (level == 1)
        {
            SceneManager.LoadScene("Level0Part2");
        }
        if (level == 2)
        {
            SceneManager.LoadScene("Level1Part1");
        }
        if (level == 3)
        {
            SceneManager.LoadScene("Level1Part2");
        }
        if (level == 4)
        {
            SceneManager.LoadScene("Level1Part3");
        }
        if (level == 5)
        {
            SceneManager.LoadScene("Level2Part1");
        }
        if (level == 6)
        {
            SceneManager.LoadScene("Level2Part2");
        }
        if (level == 7)
        {
            SceneManager.LoadScene("Leve2Part3");
        }
        if (level == 8)
        {
            SceneManager.LoadScene("Level2Part4");
        }
        if (level == 9)
        {
            SceneManager.LoadScene("Level2Part5");
        }
        if (level == 10)
        {
            SceneManager.LoadScene("Level2Part6");
        }
        if (level == 11)
        {
            SceneManager.LoadScene("Level2Part7");
        }
        if (level == 12)
        {
            SceneManager.LoadScene("Level3Part1");
        }
        if (level == 13)
        {
            SceneManager.LoadScene("Level3Part2");
        }
        if (level == 14)
        {
            SceneManager.LoadScene("Level3Part3");
        }
        if (level == 15)
        {
            SceneManager.LoadScene("Level3Part4");
        }
        if (level == 16)
        {
            SceneManager.LoadScene("LevelF");
        }
    }

}
