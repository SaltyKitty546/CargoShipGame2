using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleKeycardIfHave : MonoBehaviour
{
    // Start is called before the first frame update
    public Inventory i;
    public GameObject keycard;
    public int keycardType;


    void Start()
    {
        
        keycard.SetActive(true);
        
        if (i.haveGreenKeycard && keycardType == 1) {
            keycard.SetActive(false);
        } 

        if (i.haveRedKeycard && keycardType == 2) {
            keycard.SetActive(false);
        } 

        if (i.haveBlueKeycard && keycardType == 3) {
            keycard.SetActive(false);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
