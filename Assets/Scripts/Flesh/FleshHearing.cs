using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleshHearing : MonoBehaviour
{
    // Start is called before the first frame update
    public FleshMovement fm;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            fm.isChasing = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player") {
            fm.isChasing = false;
            fm.GetNavigationPoint();
        }
    }
}
