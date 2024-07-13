using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectedEyes : MonoBehaviour
{
    // Start is called before the first frame update

    public float maxDistance;
    public RaycastHit hit;
    public InfectedMovement i;
    public bool isActive = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive == true)
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance))
            {
                if (hit.collider.gameObject.CompareTag("Player") && isActive == true)
                {
                    i.isChasing = true;

                }
                else
                {
                    i.isChasing = false;

                }
            }
        }
    }
}
