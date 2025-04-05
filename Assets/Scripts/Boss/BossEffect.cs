using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEffect : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerController pc;
    public int attackCooldown;
    public bool isEffectActive = false;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attackCooldown -= 1;
        if (attackCooldown < 800) {
            isEffectActive = false;
        }

        if (isEffectActive) {
            pc.walkingSpeed = 2f;
            pc.runningSpeed = 2.5f;
        } else {
            pc.walkingSpeed = 2.5f;
            pc.runningSpeed = 3.9f;
        }
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Player" && attackCooldown < 0) {
            isEffectActive = true;
            attackCooldown = 1000;
        }
    }

    
}
