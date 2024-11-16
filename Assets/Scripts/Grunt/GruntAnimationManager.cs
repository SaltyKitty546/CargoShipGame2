using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruntAnimationManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GruntMovement gm;
    public GruntAttack ga;
    public Animator ganm;
    public GameObject flames;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ga.isAttacking == true && gm.isDead == false)
        {
            ganm.Play("Base Layer.Walk");
            flames.SetActive(false);
        } else
        {
            if (gm.isChasing == true && gm.isDead == false)
            {
                ganm.Play("Base Layer.Walk");
                flames.SetActive(false);
            } else if (gm.isChasing == false && gm.isDead == false)
            {
                ganm.Play("Base Layer.Idle");
                flames.SetActive(false);
            } else {
                ganm.Play("Base Layer.Death");
                flames.SetActive(true);
            }
        }
    }
}
