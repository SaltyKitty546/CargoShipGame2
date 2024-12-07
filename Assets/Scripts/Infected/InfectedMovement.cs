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
    public Radio r;
    [SerializeField] private Transform[] points;

    void Start()
    {

        points = new Transform[11];
        GameObject[] pointsObj = GameObject.FindGameObjectsWithTag("Infectedpoint");
        for (int i = 0; i < pointsObj.Length-1; i++)
        {
            points[i] = pointsObj[i].transform;
        }
        GenerateRandomDes();
    }

    // Update is called once per frame
    void Update()
    {
        if (isChasing == true)
        {
            ai.SetDestination(player.position);
        } else
        {
            
            ai.SetDestination(points[randomPoint].position);
        }

        if (r.isEnemyInUseRadius && r.isRadioOn) {
            r.inh.SetActive(false);
        } else {
            r.inh.SetActive(true);
        }
    } 

    public void GenerateRandomDes()
    {
        randomPoint = Random.Range(0, 11);
    }

    
}
