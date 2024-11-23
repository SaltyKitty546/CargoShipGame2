using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flaregun : MonoBehaviour
{
    // Start is called before the first frame update
    public Inventory i;
    public GruntMovement gm;
    public AudioSource flareShotSFX;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f") && i.selectedItem == 2 && i.flareguns > 0) {
            ShootFlare();
        }
    }

    public void ShootFlare() {
        Vector3 origin = transform.position;
        Vector3 direction = Camera.main.transform.forward;

        RaycastHit hit;
        int layer_mask = LayerMask.GetMask("Default");

        if (Physics.Raycast(origin, direction, out hit, Mathf.Infinity, layer_mask)) {
            Debug.Log("Hit object: " + hit.collider.gameObject.name);
            if (hit.collider.gameObject.name == "Grunt") {
                Debug.Log("Kill Grunt");
                gm.isDead = true;
            }
            flareShotSFX.Play();
            i.flareguns -= 1;
            ItemCycle();
        }
    }

    public void ItemCycle() {
        if (i.flashbangs > 0) {
            i.selectedItem = 1;
        } else if (i.flareguns > 0) {
            i.selectedItem = 2;
        } else if (i.radios > 0) {
            i.selectedItem = 3;
        }
    }
}
