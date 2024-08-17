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
        if (whichLevel == 1)
        {
            SceneManager.LoadScene("Level0Part1");
        }
    }
}
