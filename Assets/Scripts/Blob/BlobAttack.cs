using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BlobAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerHealthControl php;
    public BlobMovement b;
    public int attackCooldown;
    public int movementCooldown;
    public NavMeshAgent navb;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attackCooldown -= 3;
        movementCooldown -= 3;
        if (movementCooldown < 0)
        {
            navb.speed = 3.5f;

        } else
        {
            navb.speed = 1f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && attackCooldown < 1)
        {
            Debug.Log("Attacked");
            attackCooldown = 800;
            movementCooldown = 400;
            php.health -= 50;

        }
    }
}
