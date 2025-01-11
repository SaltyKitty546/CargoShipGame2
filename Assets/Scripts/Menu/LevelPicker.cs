using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPicker : MonoBehaviour
{
    // Start is called before the first frame update
    public int whichLevel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WhichLevelIsPicked()
    {
        if (whichLevel == 0)
        {
            SceneManager.LoadScene("Intro");
        }
        if (whichLevel == 1)
        {
            SceneManager.LoadScene("Level0Part1");
        }
        if (whichLevel == 2)
        {
            SceneManager.LoadScene("Level0Part2");
        }
        if (whichLevel == 3)
        {
            SceneManager.LoadScene("Level1Part1");
        }
        if (whichLevel == 4)
        {
            SceneManager.LoadScene("Level1Part2");
        }
        if (whichLevel == 5)
        {
            SceneManager.LoadScene("Level1Part3");
        }
        if (whichLevel == 6)
        {
            SceneManager.LoadScene("TheHub");
        }
        if (whichLevel == 7)
        {
            SceneManager.LoadScene("Level2Part1");
        }
    }
}
