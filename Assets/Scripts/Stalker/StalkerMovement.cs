using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StalkerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent nav;
    public Transform player;
    public PlayerHealthControl ph;
    public bool isChasing = false;

    public Animator animator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isChasing == true && ph.health > 0)
        {
            Vector3 playerPos = new Vector3(player.position.x, player.position.y, player.position.z);
            nav.SetDestination(playerPos);
            animator.Play("Base Layer.Chase");
        } else if (isChasing == false)
        {
            animator.Play("Base Layer.Idle");
        }
    }

    
}
