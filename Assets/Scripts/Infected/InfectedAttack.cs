using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class InfectedAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public InfectedMovement i;
    public NavMeshAgent iai;
    public PlayerHealthControl php;
    public int attackCooldown;
    public int attackCooldownAm;
    public InfectedEyes ie;
    public InfectedHearing ih;
    public InfectedAnimationManager iam;
    
    

    void Start()
    {
        attackCooldown = 0;
        iam.state = 1;
        
        
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && attackCooldown < 0)
        {
            iai.speed = 0.1999f;
            iam.state = 4;
            php.health -= 110;
            attackCooldown = 2200;
            attackCooldownAm = 300;
            i.isChasing = false;
            i.GenerateRandomDes();
            GameObject[] pointsObj = GameObject.FindGameObjectsWithTag("Infectedpoint");
            
            
            
            
        }

    }
}
