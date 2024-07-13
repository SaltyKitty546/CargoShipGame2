using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent nav;
    public float enemySpeed;
    public bool isChasing = false;
    public GameObject player;
    


    void Start()
    {
        nav.speed = enemySpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (isChasing == true)
        {
            nav.SetDestination(player.transform.position);
        }

    }
}   

