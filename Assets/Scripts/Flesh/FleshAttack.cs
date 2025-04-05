using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleshAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public int attackCooldown = 0;
    public PlayerHealthControl php;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attackCooldown -= 1;   
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && attackCooldown < 0)
        {
            php.health -= 10;
            attackCooldown = 450;
        }
    }
}
