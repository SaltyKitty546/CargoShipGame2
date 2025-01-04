using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class InfectedPoint : MonoBehaviour
{
    // Start is called before the first frame update

    public int pointCooldown = 0;
    public InfectedMovement i;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointCooldown -= 3;
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Infected" && pointCooldown < 1 && i.isChasing == false)
        //{
            //i.GenerateRandomDes();
            //pointCooldown = 100;
            
            //if (ih.isActive == false && ie.isActive == false)
            //{

                //ih.isActive = true;
                //ie.isActive = true;
                
            //}
            
        //}

        if (other.gameObject.tag == "Infected")
        {
            if (pointCooldown < 1)
            {
    
                Debug.Log("Re Generating");
                
                i.GenerateRandomDes();
                pointCooldown = 30;
                
            }
            
        }



    }
}
