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
    public bool isAttacking = false;
    public AudioSource attack;

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
            isAttacking = false;


        } else
        {
            navb.speed = 1f;
        }

        if (movementCooldown > 200)
        {
            isAttacking = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && attackCooldown < 1)
        {
            
            attack.Play();
            Debug.Log("Attacked");
            attackCooldown = 800;
            movementCooldown = 400;
            php.health -= 50;

        }
    }
}
