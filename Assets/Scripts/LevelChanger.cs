using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public string scenename;
    public SaveTheData sd;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
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
