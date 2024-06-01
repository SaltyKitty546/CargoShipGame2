using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecailizedDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public Inventory invp;
    public int doorType;

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
            if (doorType == 1 && invp.haveRedKeycard == true)
            {
                invp.haveRedKeycard = false;
                Destroy(gameObject);
            } else if (doorType == 2 && invp.haveGreenKeycard == true)
            {
                invp.haveGreenKeycard = false;
                Destroy(gameObject);
            } else if (doorType == 3 && invp.haveBlueKeycard == true)
            {
                invp.haveGreenKeycard = false;
                Destroy(gameObject);
            } else if (doorType == 4 && invp.crowbars > 0)
            {
                invp.crowbars -= 1;
                Destroy(gameObject);
            }
        }
    }
}
