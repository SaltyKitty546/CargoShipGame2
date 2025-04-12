using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isAttacking;
    public PlayerHealthControl php;
    public int attackCooldown;

    public AudioSource attackSound;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attackCooldown -= 1;
        if (attackCooldown < 200) {
            isAttacking = false;
        }
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Player" && attackCooldown < 0) {
            php.health -= 80;
            isAttacking = true;
            attackCooldown = 500;
        }
    }
}
