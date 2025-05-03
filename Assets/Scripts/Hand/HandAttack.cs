using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAttack : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayerHealthControl php;
    public int attackCooldown;
    public Animator a;
    public bool isAttacking;
    public GameObject handModel;
    public Transform player;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attackCooldown -= 2;
        if (attackCooldown < 400)
        {
            isAttacking = false;
        } 

        if (isAttacking)
        {
            a.Play("Base Layer.Attack");
            //handModel.transform.rotation = Quaternion.Euler(transform.rotation.x, , transform.rotation.z);
        } else
        {
            a.Play("Base Layer.Idle");
        }
    }

    private void OnTriggerStay(Collider other) {
        if (attackCooldown < 0 && other.gameObject.tag == "Player") {
            attackCooldown = 800;
            php.health =- 50;
            isAttacking = true;
            
        }
    }
}
