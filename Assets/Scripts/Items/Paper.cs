using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject paperCanvasObject;
    public

    void Start()
    {
        paperCanvasObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            paperCanvasObject.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown("e"))
        {
            paperCanvasObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        paperCanvasObject.SetActive(false);
    }
}
