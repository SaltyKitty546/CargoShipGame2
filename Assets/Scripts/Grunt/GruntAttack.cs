using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruntAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public int attackCooldown;
    public PlayerHealthControl php;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attackCooldown -= 3;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && attackCooldown < 0)
        {
            php.health -= 55;
            attackCooldown = 1000;
        }
    }
}
