using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class InfectedMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent ai;
    public bool isChasing = false;
    public Transform player;
    public int randomPoint;
    [SerializeField] private Transform[] points;

    void Start()
    {

        points = new Transform[12];
        GameObject[] pointsObj = GameObject.FindGameObjectsWithTag("Infectedpoint");
        for (int i = 0; i < pointsObj.Length-1; i++)
        {
            points[i] = pointsObj[i].transform;
        }
        randomPoint = Random.Range(0, 11);

    }

    // Update is called once per frame
    void Update()
    {
        if (isChasing == true)
        {
            ai.SetDestination(player.position);
        } else
        {
            
            ai.SetDestination(points[randomPoint].transform.position);
        }
    }

    
}
