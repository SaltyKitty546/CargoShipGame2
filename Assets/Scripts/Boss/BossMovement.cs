using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent nav;
    public int destinationCooldown;
    public Transform player;
    public BossAttack ba;

    public Animator a;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ba.isAttacking == false) {
            nav.speed = 4;
            a.Play("Base Layer.Run");
        } else {
            nav.speed = 1;
            a.Play("Base Layer.Attack");
        }
        
        destinationCooldown -= 1;
        if (destinationCooldown < 0) {
            Vector3 playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
            nav.SetDestination(playerPosition);
            destinationCooldown = 70;
        }
       
    }
}
