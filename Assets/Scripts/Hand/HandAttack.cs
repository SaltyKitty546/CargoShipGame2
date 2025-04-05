using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAttack : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayerHealthControl php;
    public int attackCooldown;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attackCooldown -= 2;
    }

    private void OnTriggerStay(Collider other) {
        if (attackCooldown < 0 && other.gameObject.tag == "Player") {
            php.health =- 50;
            attackCooldown = 400;
        }
    }
}
