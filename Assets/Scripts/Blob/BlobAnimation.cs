using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobAnimation : MonoBehaviour
{
    // Start is called before the first frame update

    public BlobMovement bm;
    public BlobAttack ba;
    public Animator bani;
    public int animationState;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (animationState == 1)
        {
            bani.Play("Base Layer.Idle");
        }
        if (animationState == 2)
        {
            bani.Play("Base Layer.Chase");
        }
        if (animationState == 3)
        {
            bani.Play("Base Layer.Attack");
        }


        if (ba.isAttacking == true)
        {
            animationState = 3;
        } else
        {
            if (bm.isChasing == true)
            {
                animationState = 2;
            } else
            {
                animationState = 1;
            }
        }

    }
}
