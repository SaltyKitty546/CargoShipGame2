using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BlobMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent ai;
    public int whichPoint;
    private int pointCooldown;
    public bool isChasing = false;
    

    public GameObject player;

    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    public GameObject point4;

    void Start()
    {
        whichPoint = 1;
    }

    // Update is called once per frame
    void Update()
    {
        pointCooldown -= 1;


        if (isChasing == true)
        {
            whichPoint = 0;
            
        }

        switch (whichPoint)
        {
            
            case 0:
                ai.SetDestination(player.transform.position);
                break;
            case 1:
                ai.SetDestination(point1.transform.position);
                break;
            case 2:
                ai.SetDestination(point2.transform.position);
                break;
            case 3:
                ai.SetDestination(point3.transform.position);
                break;
            case 4:
                ai.SetDestination(point4.transform.position);
                break;
        }
    } 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Point" && pointCooldown < 0 && isChasing == false)
        {
            whichPoint += 1;
            pointCooldown = 100;
        }
        if (other.gameObject.tag == "LastPoint" && pointCooldown < 0 && isChasing == false)
        {
            whichPoint = 1;
        }
    }
}
