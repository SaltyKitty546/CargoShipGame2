using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update
    public int crowbars;
    public bool haveRedKeycard = false;
    public bool haveGreenKeycard = false;
    public bool haveBlueKeycard = false;

    public TMP_Text redKeycardText;
    public TMP_Text greenKeycardText;
    public TMP_Text blueKeycardText;
    public TMP_Text crowbarCountText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        string crw = "Crowbar Count: " + crowbars.ToString();
        crowbarCountText.text = crw;



        if (haveRedKeycard)
        {
            redKeycardText.text = "Red Keycard";
        } else
        {
            redKeycardText.text = "";
        }

        if (haveGreenKeycard)
        {
            greenKeycardText.text = "Green Keycard";
        }
        else
        {
            greenKeycardText.text = "";
        }

        if (haveBlueKeycard)
        {
            blueKeycardText.text = "Blue Keycard";
        }
        else
        {
            blueKeycardText.text = "";
        }
    }
}
