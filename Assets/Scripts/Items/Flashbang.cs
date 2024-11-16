using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Flashbang : MonoBehaviour
{
    // Start is called before the first frame update

    public Inventory i;
    public NavMeshAgent b;
    public int effectCooldown;
    public int splashCooldown;
    public bool isFlashUsed = false;
    public bool isEnemyInFlashRadius = false;
    public GameObject flashbangSplash;
    public AudioSource flashbangSFX;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        effectCooldown -= 1; 
        splashCooldown -= 1;
        
        //if (effectCooldown < 1) {
        //    b.speed = 3.5f;
        //}

        if (splashCooldown < 1) {
            flashbangSplash.SetActive(false);
        }


        
        if (i.flashbangs > 0) {
            if (i.selectedItem == 1) {
                if (Input.GetKeyDown("f")) {
                    isFlashUsed = true;
                }
            }
        }
    }

    public void UseFlash() {
        //flashbangSplash.SetActive(true);
        effectCooldown = 500;
        //splashCooldown = 10;
        b.speed = 0.75f;
        i.flashbangs -= 1;
        ItemCycle();
        
    }

    public void SpawnFlashbangSplash() {
        flashbangSFX.Play();
        flashbangSplash.SetActive(true);
        splashCooldown = 20;
        i.flashbangs -= 1;
        ItemCycle();
    }

    public void OnTriggerStay(Collider other) {
        if (isFlashUsed == true) {
            if (other.gameObject.tag == "Blob") {
                isEnemyInFlashRadius = true;
                isFlashUsed = false;
                UseFlash();
                SpawnFlashbangSplash();
            } else {
                isEnemyInFlashRadius = false;
                isFlashUsed = false;
                SpawnFlashbangSplash();
            }
            //UseFlash();
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
