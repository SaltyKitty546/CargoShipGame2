using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeycardPickup : MonoBehaviour
{
    // Start is called before the first frame update

    public Inventory invp;
    public int whichKeycard;
    public TMP_Text itemPickupText;
    public string itemName;
    public GameObject itemModel;
    

    void Start()
    {
        itemModel.SetActive(true);
        itemPickupText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeItemPickupText()
    {
        string itemPickupChangeback = "";
        itemPickupText.text = itemPickupChangeback;
        Destroy(itemModel);
        Destroy(gameObject);

    }

    private void OnTriggerStay (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            if (whichKeycard == 1)
            {
                invp.haveRedKeycard = true;
            } else if (whichKeycard == 2)
            {
                invp.haveGreenKeycard = true;
            } else if (whichKeycard == 3)
            {
                invp.haveBlueKeycard = true;
            } else
            {

            }
            
            Invoke("ChangeItemPickupText", 1.75f);
            string itemPickupMessage = "You picked up " + itemName;
            itemPickupText.text = itemPickupMessage;
            itemModel.SetActive(false);

        }
    }
}
