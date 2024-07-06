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

    void Start()
    {
        attackCooldown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        attackCooldown -= 3;
        if (attackCooldown < -2)
        {
            attackCooldown = -1;
        }

        if (attackCooldown < 400)
        {
            iai.speed = 4f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && attackCooldown < 0)
        {
            iai.speed = 1.2f;
            php.health -= 35;
            attackCooldown = 2000;
        }

    }
}
