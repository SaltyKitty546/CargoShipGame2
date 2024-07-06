using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectedHearing : MonoBehaviour
{

    public InfectedMovement i;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            i.isChasing = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            i.isChasing = false;
        }
    }

    



}
