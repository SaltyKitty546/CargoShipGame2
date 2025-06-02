using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Part1Special : MonoBehaviour
{
    // Start is called before the first frame update
    public Inventory i;
    private int cooldown = 500;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= 5;
        if (cooldown > 0)
        {
            i.haveBlueKeycard = false;
            i.haveRedKeycard = false;
            i.haveGreenKeycard = false;
        }
    }
}
