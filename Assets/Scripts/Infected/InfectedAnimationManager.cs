using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectedAnimationManager : MonoBehaviour
{
    // Start is called before the first frame update

    public int state;
    public InfectedAttack i;
    public Animator anmi;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (state == 1)
        {
            anmi.Play("Base Layer.Sprint");
        }

        if (state == 2)
        {
            anmi.Play("Base Layer.Meduim Walk");
        }

        if (state == 3)
        {
            anmi.Play("Base Layer.Slow Walk");
        }

        if (state == 4)
        {
            anmi.Play("Base Layer.Attack");
        }
    }
}
