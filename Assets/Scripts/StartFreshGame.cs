using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartFreshGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject loadingScreen;
    void Start()
    {
        loadingScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            loadingScreen.SetActive(true);
            SceneManager.LoadScene("IntroCutscene");
        }
    }
}
