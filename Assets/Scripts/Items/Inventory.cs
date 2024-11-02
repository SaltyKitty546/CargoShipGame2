using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update
    
    //Items
    public int crowbars;
    public bool haveRedKeycard = false;
    public bool haveGreenKeycard = false;
    public bool haveBlueKeycard = false;
    public int flashbangs;
    public int flareguns;
    public int radios;

    public bool hasItems = false;
    public int selectedItem = 3;

    //UI
    public GameObject redKeycard;
    public GameObject greenKeycard;
    public GameObject blueKeycard;

    public GameObject crowbar1;
    public GameObject crowbar2;
    public GameObject crowbar3;
    
    //SaveData
    public string sceneName;
    public SaveTheData sd;


    void Start()
    {

        sd.LoadData();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (flashbangs > 0 || flareguns > 0 || radios > 0) {
            hasItems = true;
        } else {
            hasItems = false;
        }
        
        if (crowbars > 3)
        {
            crowbars = 3;
        } 


        if (haveRedKeycard)
        {
            redKeycard.SetActive(true);
        } else
        {
            redKeycard.SetActive(false);
        }

        if (haveGreenKeycard)
        {
            greenKeycard.SetActive(true);
        }
        else
        {
            greenKeycard.SetActive(false);
        }

        if (haveBlueKeycard)
        {
            blueKeycard.SetActive(true);
        }
        else
        {
            blueKeycard.SetActive(false);
        }

        if (crowbars == 1)
        {
            crowbar1.SetActive(true);
            crowbar2.SetActive(false);
            crowbar3.SetActive(false);
        }

        if (crowbars == 2)
        {
            crowbar1.SetActive(true);
            crowbar2.SetActive(true);
            crowbar3.SetActive(false);
        }

        if (crowbars == 3)
        {
            crowbar1.SetActive(true);
            crowbar2.SetActive(true);
            crowbar3.SetActive(true);
        }

        if (crowbars == 0)
        {
            crowbar1.SetActive(false);
            crowbar2.SetActive(false);
            crowbar3.SetActive(false);
        }

    }
}
