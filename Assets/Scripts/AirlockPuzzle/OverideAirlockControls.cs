using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverideAirlockControls : MonoBehaviour
{
    // Start is called before the first frame update
    public OpenAirlockDoor oald;
    public Inventory i;
    //public AudioSource overideSound;
    //public AudioSource crowbarSound;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Player") {
            if (Input.GetKeyDown("e") && i.crowbars > 0 && oald.isOverideActive == false) {
                oald.isOverideActive = true;
                i.crowbars -= 1;
                //overideSound.Play();
                //crowbarSound.Play();

            } 
        }
    }
}
