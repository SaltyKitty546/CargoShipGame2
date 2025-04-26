using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectButton : MonoBehaviour
{
    // Start is called before the first frame update
    public string stringScene;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPress()
    {
        SceneManager.LoadScene("LevelSelectScreen");
    }

    public void BackPress()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Press()
    {
        SceneManager.LoadScene(stringScene);
    }
}
