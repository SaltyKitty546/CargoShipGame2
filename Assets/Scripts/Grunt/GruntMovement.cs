using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GruntMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isChasing = false;
    public NavMeshAgent ai;
    public GameObject player;

    public float maxDistance;
    public RaycastHit hit;

    public GameObject footsteps;
    public GameObject chaseRoar;

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
                isChasing = true;
                

            } else
            {
                isChasing = false;
                
            }
        }
        
        if (isChasing == true)
        {
            ai.SetDestination(player.transform.position);
            footsteps.SetActive(true);
            chaseRoar.SetActive(true);
        } else
        {
            footsteps.SetActive(false);
            chaseRoar.SetActive(false);
        }

    }
}
