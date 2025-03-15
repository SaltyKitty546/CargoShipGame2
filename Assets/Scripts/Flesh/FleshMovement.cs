using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FleshMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent nav;
    public bool isChasing = false; 
    public GameObject player;
    
    public int maxAmountOfPoints;
    public GameObject[] navPoints;

    void Start()
    {
        Invoke("GetNavigationPoint", 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (isChasing) {
            nav.SetDestination(player.transform.position);
        }
    }

    public void GetNavigationPoint() {

        int i = Random.Range(0, maxAmountOfPoints);
        nav.SetDestination(navPoints[i].transform.position);
        Debug.Log("point " + i);
    }


}
