using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    // Start is called before the first frame update
    public Inventory i;
    public GameObject inh;
    public bool isUsed = false;
    public int radioInUsePeriod;
    public bool isEnemyInUseRadius = false;
    public bool isRadioOn = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        radioInUsePeriod -= 1;

        if (radioInUsePeriod < 1) {
            isRadioOn = false;
        } else {
            Debug.Log("e");
        }

        if (i.radios > 0) {
            if (i.selectedItem == 3) {
                if (Input.GetKeyDown("f")) {
                    isUsed = true;
                }
            }
        }
    }

    public void UsedRadio() {
        i.radios -= 1;
        isRadioOn = true;
        radioInUsePeriod = 455;
        isUsed = false;
        ItemCycle();
        

    }
    
    private void OnTriggerStay(Collider other) {
        if (isUsed == true) {
            UsedRadio();
        }

        if (other.gameObject.tag == "Infected") {
            isEnemyInUseRadius = true;
        } else {
            isEnemyInUseRadius = false;
        }
    }

    public void ItemCycle() {
        if (i.flashbangs > 0) {
            i.selectedItem = 1;
        } else if (i.flareguns > 0) {
            i.selectedItem = 2;
        } else if (i.radios > 0) {
            i.selectedItem = 3;
        }
    } 


}
