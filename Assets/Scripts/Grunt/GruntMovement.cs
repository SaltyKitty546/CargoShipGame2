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

    public int chaseLast;

    public bool isDead = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        chaseLast -= 1;
        
        Debug.Log(maxDistance);
        Debug.DrawRay(transform.position, transform.forward, Color.red, maxDistance);
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance))
        {
            Debug.Log("cast triggered");
            Debug.Log(hit.collider.gameObject.name);
            if (hit.collider.gameObject.name == "Player")
            {
                isChasing = true;
                Debug.Log("Grunt see player");
                chaseLast = 120;

            } else
            {
                if (chaseLast < 0)
                {
                    isChasing = false;
                }
                
                
            }
        }

        if (isChasing == true && isDead == false)
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
