using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Part1Special : MonoBehaviour
{
    // Start is called before the first frame update
    public Inventory i;

    void Start()
    {
        i.haveBlueKeycard = true;
        i.haveRedKeycard = true;
        i.haveGreenKeycard = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
