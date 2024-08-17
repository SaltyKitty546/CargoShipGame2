using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruntAnimationManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GruntMovement gm;
    public GruntAttack ga;
    public Animator ganm;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ga.isAttacking == true)
        {
            ganm.Play("Base Layer.Walk");
        } else
        {
            if (gm.isChasing == true)
            {
                ganm.Play("Base Layer.Walk");
            } else
            {
                ganm.Play("Base Layer.Idle");
            }
        }
    }
}
