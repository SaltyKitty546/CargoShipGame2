using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPickedUp = false;
    public GameObject itemViewmodel;
    public GameObject itemModel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPickedUp) {
            itemViewmodel.SetActive(true);
            itemModel.SetActive(false);
        } else {
            itemViewmodel.SetActive(false);
            itemModel.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (isPickedUp == false) {
            isPickedUp = true;
        }
    }
}
