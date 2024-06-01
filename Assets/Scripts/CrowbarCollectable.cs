using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CrowbarCollectable : MonoBehaviour
{
    // Start is called before the first frame update

    public Inventory invp;
    
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

            if (isItemPickedUp == false)
            {
                invp.crowbars += 1;
                pickupSound.Play();
                isItemPickedUp = true;
            }
            Invoke("ChangeItemPickupText", 1.75f);
            string itemPickupMessage = "You picked up " + itemName;
            itemPickupText.text = itemPickupMessage;
            itemModel.SetActive(false);

        }
    }
}
