using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BlobHearing : MonoBehaviour
{
    // Start is called before the first frame update
    //private NavMeshPath path;
    public BlobMovement b;
    void Start()
    {
        //path = new NavMeshPath();
    }

    // Update is called once per frame
    void Update()
    {
        if (b.isChasing == true)
        {
            //b.ai.CalculatePath(b.gameObject.transform.position, b.player.transform.position, NavMesh.AllAreas, path);
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            b.isChasing = true;
        }
    }

    
}
