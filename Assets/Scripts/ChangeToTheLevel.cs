using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToTheLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneName;
    public GameObject loadingScreen;
    void Start()
    {
        loadingScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            loadingScreen.SetActive(true);
            SceneManager.LoadScene(sceneName);
        }

    }
}
