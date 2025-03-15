using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleshPoint : MonoBehaviour
{
    // Start is called before the first frame update
    public FleshMovement fm;
    public string pointName;
    public int pointCooldown;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       pointCooldown -= 1;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Flesh" /*&& fm.nav.remainingDistance < 1 */&& pointCooldown < 0) {
            pointCooldown = 500;
            Debug.Log(pointName);
            fm.GetNavigationPoint();
        }
    }
}
