using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HUDControl : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject inventory;
    public bool hudEnabled;

    

    void Start()
    {
        hudEnabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (hudEnabled == true)
        {
            inventory.SetActive(true);
        } else
        {
            inventory.SetActive(false);
        }
        
        if (Input.GetKeyDown(KeyCode.H) && hudEnabled == false)
        {
            EnableHud();
        }
    }
    
    public void EnableHud()
    {
        hudEnabled = true;
        Invoke("DisableHud", 2.2f);
    }
    public void DisableHud()
    {
        hudEnabled = false;
    }
}
