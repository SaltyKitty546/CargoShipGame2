using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalkerVision : MonoBehaviour
{
    // Start is called before the first frame update
    public StalkerMovement stal;
    public bool isFound = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && isFound == false)
        {
            stal.isChasing = true;
            isFound = true;
        }
    }
}
