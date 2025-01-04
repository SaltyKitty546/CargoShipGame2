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
    public int pointCooldown;
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
        pointCooldown -= 1;
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
        randomPoint = Random.Range(0, 3);
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Infected" && pointCooldown < 1 && i.isChasing == false)
        //{
        //i.GenerateRandomDes();
        //pointCooldown = 100;

        //if (ih.isActive == false && ie.isActive == false)
        //{

        //ih.isActive = true;
        //ie.isActive = true;

        //}

        //}

        if (other.gameObject.tag == "Infectedpoint")
        {
            if (pointCooldown < 1)
            {

                Debug.Log("Re Generating");

                GenerateRandomDes();
                pointCooldown = 30;

            }

        }



    }


}
