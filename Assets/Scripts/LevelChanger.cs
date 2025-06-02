using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public string scenename;
    public SaveTheData sd;
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
            StartCoroutine(SaveGame());
            SceneManager.LoadScene(scenename);
            
        }
    }

    private IEnumerator SaveGame()
    {
        sd.SavingData();
        yield return new WaitForSeconds(2f);
    }
}
