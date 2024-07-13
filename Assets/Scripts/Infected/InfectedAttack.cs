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
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        attackCooldown -= 3;
        attackCooldownAm -= 3;
        
        if (attackCooldownAm < -2)
        {
            attackCooldownAm = -2;

        }

        if (attackCooldown < -2)
        {
            attackCooldown = -1;
            iam.state = 1;



        }

        if (attackCooldownAm < 0)
        {
            

            if (attackCooldown < 1400 && 0 < attackCooldown )
            {
                iai.speed = 2f;
                iam.state = 2;
            }

            if (iai.speed == 0.1999f)
            {
                iam.state = 3;
            }
        } else
        {
            iam.state = 4;
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && attackCooldown < 0)
        {
            iai.speed = 0.1999f;
            iam.state = 4;
            php.health -= 35;
            attackCooldown = 2200;
            attackCooldownAm = 300;
            i.isChasing = false;
            i.GenerateRandomDes();
            GameObject[] pointsObj = GameObject.FindGameObjectsWithTag("Infectedpoint");
            for (int i = 0; i < pointsObj.Length - 1; i++)
            {

                InfectedPoint ip = pointsObj[i].GetComponent<InfectedPoint>();
                ip.pointCooldown = 0;
            }
            ie.isActive = false;
            ih.isActive = false;
            
            
        }

    }
}
