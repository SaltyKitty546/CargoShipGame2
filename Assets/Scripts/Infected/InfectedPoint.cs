using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectedPoint : MonoBehaviour
{
    // Start is called before the first frame update
    public InfectedMovement i;
    public int pointCooldown;
    

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
        if (other.gameObject.tag == "Infected" && pointCooldown < 1)
        {
            i.randomPoint = Random.Range(0, 11);
            pointCooldown = 200;
        }
    }
}
