using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gate;
    public Inventory i;
    public bool isOpen = false;
    public AudioSource buttonPress;
    public AudioSource gateOpen;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpen) {
            gate.SetActive(false);
        } else {
            gate.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown("e")) {
            if (i.haveRedKeycard && i.haveBlueKeycard && i.haveGreenKeycard) {
                isOpen = true;
                
                buttonPress.Play();
                gateOpen.Play();
            }
        }
    }
}
