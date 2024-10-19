using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectOnTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawnObject;
    public bool isSpawned = false;

    void Start()
    {
        CheckIfObjectSpawned();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && isSpawned == false)
        {
            isSpawned = true;
            CheckIfObjectSpawned();
        }
    }

    public void CheckIfObjectSpawned()
    {
        if (isSpawned == true)
        {
            spawnObject.SetActive(true);
        } else
        {
            spawnObject.SetActive(false);
        }
    }
}
