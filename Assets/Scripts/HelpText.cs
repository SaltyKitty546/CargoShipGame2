using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HelpText : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text helpText;
    private int rand;

    void Start()
    {
        rand = Random.Range(0, 15);
        if (rand == 1)
        {
            helpText.text = "ℹ️ Tip: Flaregun shots only work on grunts. No other monster will die to them.";
        }
        if (rand == 2)
        {
            helpText.text = "ℹ️ Tip: Your steps can be inflected through the ship, allowing for them to hear you.";
        }
        if (rand == 3)
        {
            helpText.text = "ℹ️ Tip: The one eyed monsters are called Grunts.";
        }
        if (rand == 4)
        {
            helpText.text = "ℹ️ Tip: The tall monsters are called Stalkers.";
        }
        if (rand == 5)
        {
            helpText.text = "ℹ️ Tip: The blobs of flesh are obviously titled Blobs.";
        }
        if (rand == 6)
        {
            helpText.text = "ℹ️ Tip: The sickly green ones are called Infected.";
        }
        if (rand == 7)
        {
            helpText.text = "ℹ️ Tip: The rocks are an illusion.";
        }
        if (rand == 8)
        {
            helpText.text = "ℹ️ Tip: Radio waves destroy the Infected's ears.";
        }
        if (rand == 9)
        {
            helpText.text = "ℹ️ Tip: Reality warping leads to Stalkers hearing you where they should not.";
        }
        if (rand == 10)
        {
            helpText.text = "ℹ️ Tip: You would not have been here if it was not for their idiocy.";
        }
        if (rand == 11)
        {
            helpText.text = "ℹ️ Tip: The Security Manager was right.";
        }
        if (rand == 12)
        {
            helpText.text = "ℹ️ Tip: Flashbangs can sometimes not work.";
        }
        if (rand == 13)
        {
            helpText.text = "ℹ️ Tip: Look around. Secrets lie near.";
        }
        if (rand == 14)
        {
            helpText.text = "ℹ️ Tip: Walk into the fire.";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
