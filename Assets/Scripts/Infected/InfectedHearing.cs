using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectedHearing : MonoBehaviour
{

    public InfectedMovement i;
    public bool isActive = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && isActive == true)
        {
            i.isChasing = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && isActive == true)
        {
            i.isChasing = false;
        }
    }

    



}
