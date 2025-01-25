using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAirlockDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject airlockDoor;
    public bool isAirlockDoorOpen;
    public bool isOverideActive;

    //public AudioSource openSound;
    //public AudioSource closeSound;
    //public AudioSource doorOpening;

    void Start()
    {
        isAirlockDoorOpen = false;
        isOverideActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isAirlockDoorOpen) {
            airlockDoor.SetActive(false);
        } else {
            airlockDoor.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other) {
        
        if (Input.GetKeyDown("e") && other.gameObject.tag == "Player") {
            if (isOverideActive) {
                isAirlockDoorOpen = true;
                //doorOpening.Play();
                //openSound.Play();
            } else {
                //closeSound.Play();
            }
        }
    }
}
