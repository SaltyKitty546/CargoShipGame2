using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruntAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public int attackCooldown;
    public PlayerHealthControl php;
    public bool isAttacking = false;
    public AudioSource attack;
    public GruntMovement gm;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attackCooldown -= 3;
        if (attackCooldown < 850)
        {
            isAttacking = false;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && attackCooldown < 0 && gm.isDead == false)
        {
            isAttacking = true;
            attack.Play();
            php.health -= 55;
            attackCooldown = 1000;
        }
    }
}
