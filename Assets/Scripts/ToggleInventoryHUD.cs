using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleInventoryHUD : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject invObject;
    public int isToggled = 0;
    public int cooldownToggle;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldownToggle -= 1;
        if (Input.GetKeyDown("h")) {
            isToggled += 1;
            cooldownToggle = 300;
        }
        if (isToggled > 1) {
            isToggled = 0;
        }
        if (isToggled == 1) {
            invObject.SetActive(true);
        } else {
            invObject.SetActive(false);
        }
    }

}
