using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPickedUp = false;
    public GameObject itemModel;
    public int whichItem;
    public Inventory i;
    public TMP_Text itemPickupText;
    public string itemName;
    public AudioSource itemPickup;
    
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPickedUp) {
            itemModel.SetActive(false);
        } else {
            itemModel.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (isPickedUp == false && other.gameObject.tag == "Player") {
            itemPickupText.text = "You picked up " + itemName;
            itemPickup.Play();
            Invoke("ChangeItemPickupText", 1.75f);
            Invoke("RemoveItem", 1.75f);
            isPickedUp = true;
            i.selectedItem = whichItem;
            ItemSelected();
        }
    }

    public void ItemSelected() { 
        if (whichItem == 1)
        {
            i.flashbangs += 1;
        }
        if (whichItem == 2)
        {
            i.flareguns += 1;
        }
        if (whichItem == 3)
        {
            i.radios += 1;
        }
    }

    void ChangeItemPickupText()
    {
        string itemPickupChangeback = "";
        itemPickupText.text = itemPickupChangeback;

    }

    void RemoveItem()
    {
        Destroy(gameObject);

    }
}
