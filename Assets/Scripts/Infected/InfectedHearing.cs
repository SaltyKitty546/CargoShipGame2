using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectedHearing : MonoBehaviour
{

    public InfectedMovement i;
    public bool isActive = true;
    public bool isHeard = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && isActive == true)
        {
            isHeard = true;
        } 
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && isActive == true)
        {
            isHeard = true;
        } 
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && isActive == true)
        {
            isHeard = false;
        } 
    }


}
