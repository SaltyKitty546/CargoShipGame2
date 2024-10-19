using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gateClosed;
    public GameObject gateOpen;
    public bool isPressed = false;
    public AudioSource gateOpeningNoise;


    void Start()
    {
        changeDoorModel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown("e") && isPressed == false)
            {
                isPressed = true;
                gateOpeningNoise.Play();
                changeDoorModel();
            }
        }
    }

    public void changeDoorModel ()
    {
        if (isPressed)
        {
            gateOpen.SetActive(true);
            gateClosed.SetActive(false);
        } else
        {
            gateOpen.SetActive(false);
            gateClosed.SetActive(true);
        }
    }
}
