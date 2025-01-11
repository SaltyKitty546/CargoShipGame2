using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnEnemiesWithTranstion : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject go;
    public GameObject image;
    public AudioSource sound;
    public int imageCooldown;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        imageCooldown -= 1;
        if (imageCooldown < 0 ) 
        { 
            image.SetActive(false);
        } else
        {
            image.SetActive(true);
        }
    }

    private void OnTriggerEnter (Collider other)
    {
        go.SetActive(false);
        imageCooldown = 200;
        sound.Play();
    }
}
