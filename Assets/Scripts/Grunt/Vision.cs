using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vision : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxDistance;
    public RaycastHit hit;
    public Movement m;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance))
        {
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                m.isChasing = true;
            } else
            {
                m.isChasing = false;
            }
        }
    }
}
