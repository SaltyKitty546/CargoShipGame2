using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthCollectable : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayerHealthControl phc;
    public int healthGiveAmount;
    public TMP_Text itemPickupText;
    public string itemName;
    public GameObject itemModel;
    private bool isItemPickedUp = false;
    

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


            if (phc.health > 99)
            {

            }
            else
            {
                if (isItemPickedUp == false)
                {
                    phc.health += healthGiveAmount;
                    isItemPickedUp = true;
                    
                }
                Invoke("ChangeItemPickupText", 1.75f);
                string itemPickupMessage = "You picked up " + itemName;
                itemPickupText.text = itemPickupMessage;
                itemModel.SetActive(false);
            }
            
        }
    }
}
