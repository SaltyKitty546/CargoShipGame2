using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodCollectable : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayerHealthControl phc;
    public int hungerGiveAmount;
    public TMP_Text itemPickupText;
    public string itemName;
    public GameObject itemModel;
    private bool isItemPickedUp = false;
    public AudioSource pickupSound;

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


            if (phc.hungerLevel > 9)
            {

            }
            else
            {
                if (isItemPickedUp == false)
                {
                    phc.hungerLevel += hungerGiveAmount;
                    isItemPickedUp = true;
                    pickupSound.Play();
                }
                Invoke("ChangeItemPickupText", 1.75f);
                string itemPickupMessage = "You picked up " + itemName;
                itemPickupText.text = itemPickupMessage;
                itemModel.SetActive(false);
            }
            
        }
    }
}
