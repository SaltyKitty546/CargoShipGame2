using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToLevel0 : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneName;
    public bool cutscene;
    public float cutsceneTime;
    void Start()
    {
        if (cutscene) {
            Invoke("ChangeScene", cutsceneTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            ChangeScene();
        }
    }

    public void ChangeScene(){
        SceneManager.LoadScene(sceneName);
    }

    
}
