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
   
    public AudioSource chase;
    public AudioSource scream;
    public AudioSource footsteps;
    public int chaseAudioPlayerCooldown;
    public int screamAudioPlayerCooldown;
    public bool isFootstepsPlayed = false;


    public Animator animator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        chaseAudioPlayerCooldown -= 3;
        screamAudioPlayerCooldown -= 3;


        if (isChasing == true && ph.health > 0)
        {
            
            if (isFootstepsPlayed == false)
            {
                footsteps.Play();
                isFootstepsPlayed = true;
            }
            Vector3 playerPos = new Vector3(player.position.x, player.position.y, player.position.z);
            nav.SetDestination(playerPos);
            animator.Play("Base Layer.Chase");
            if (chaseAudioPlayerCooldown < 0)
            {
                chase.Play();
                chaseAudioPlayerCooldown = 500;
            }

            if (screamAudioPlayerCooldown < 0)
            {
                scream.Play();
                screamAudioPlayerCooldown = 400;
            }
        } else if (isChasing == false)
        {
            animator.Play("Base Layer.Idle");
        }
    }

    
}
