using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Inventory inv;

    public GameObject noItem;
    public GameObject flashbang;
    public GameObject flaregun;
    public GameObject radio;

    public GameObject flashbangViewmodel;
    public GameObject flaregunViewmodel;
    public GameObject radioViewmodel;
    
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        
        if (inv.hasItems == true) {
            if (inv.selectedItem == 1) {
                noItem.SetActive(false);
                flashbang.SetActive(true);
                flaregun.SetActive(false);
                radio.SetActive(false);

                flashbangViewmodel.SetActive(true);
                flaregunViewmodel.SetActive(false);
                radioViewmodel.SetActive(false);

            } else if (inv.selectedItem == 2) {
                noItem.SetActive(false);
                flashbang.SetActive(false);
                flaregun.SetActive(true);
                radio.SetActive(false);

                flashbangViewmodel.SetActive(false);
                flaregunViewmodel.SetActive(true);
                radioViewmodel.SetActive(false);
            } else if (inv.selectedItem == 3) {
                noItem.SetActive(false);
                flashbang.SetActive(false);
                flaregun.SetActive(false);
                radio.SetActive(true);

                flashbangViewmodel.SetActive(false);
                flaregunViewmodel.SetActive(false);
                radioViewmodel.SetActive(true);
            }
        } else {
            noItem.SetActive(true);
            flashbang.SetActive(false);
            flaregun.SetActive(false);
            radio.SetActive(false);
            flashbangViewmodel.SetActive(false);
            flaregunViewmodel.SetActive(false);
            radioViewmodel.SetActive(false);
        }

        if (inv.hasItems == true) {
            if (Input.GetKeyDown("1")) {
                if (inv.flashbangs > 0) {
                    inv.selectedItem = 1;
                }
            }
            if (Input.GetKeyDown("2")) {
                if (inv.flareguns > 0) {
                    inv.selectedItem = 2;
                }
            }
            if (Input.GetKeyDown("3")) {
                if (inv.radios > 0) {
                    inv.selectedItem = 3;
                }
            }
        }


    }
}
