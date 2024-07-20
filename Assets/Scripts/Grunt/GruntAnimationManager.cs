using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruntAnimationManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GruntMovement gm;
    public GruntAttack ga;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ga.isAttacking == true)
        {
            //attack
        } else
        {
            if (gm.isChasing == true)
            {
                //run
            } else
            {
                //idle
            }
        }
    }
}
