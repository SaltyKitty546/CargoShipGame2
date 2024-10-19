using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnObject : MonoBehaviour
{
    public GameObject spawnObject;
    public bool isSpawned = true;

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
        if (other.gameObject.tag == "Player" && isSpawned == true)
        {
            isSpawned = false;
            CheckIfObjectSpawned();
        }
    }

    public void CheckIfObjectSpawned()
    {
        if (isSpawned == true)
        {
            spawnObject.SetActive(true);
        }
        else
        {
            spawnObject.SetActive(false);
        }
    }
}
