using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobEyes : MonoBehaviour
{
    // Start is called before the first frame update
    public BlobMovement b;
    public float maxDistance;
    public RaycastHit hit;
    
    

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.DrawRay(transform.position, transform.forward, Color.red);
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance))
        { 
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                b.isChasing = true;
                Debug.Log("Hit");
            } else
            {
                b.isChasing = false;
                Debug.Log("Miss");
            }
        }
    }
}
