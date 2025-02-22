using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobEyes : MonoBehaviour
{
    // Start is called before the first frame update
    public BlobMovement b;
    public float maxDistance;
    public RaycastHit hit;
    public AudioSource whenSaw;
    public int playCooldown;
    public bool isPlayerSeen;
    

    void Start()
    {
        playCooldown = 0;
    }

    // Update is called once per frame
    void Update()
    {

        playCooldown -= 2;
        Debug.DrawRay(transform.position, transform.forward, Color.red);
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance))
        { 
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                if (playCooldown < 0)
                {
                    whenSaw.Play();
                    playCooldown = 1475;
                }
                isPlayerSeen = true;
                Debug.Log("Hit");
            } else
            {
                isPlayerSeen = false;
                Debug.Log("Miss");
            }
        }
    }
}
