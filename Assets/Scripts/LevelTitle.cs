using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTitle : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject levelTitle;
    public AudioSource ts;
    private int titleCooldown = 1000;

    void Start()
    {
        levelTitle.SetActive(true);
        ts.Play();

    }

    // Update is called once per frame
    void Update()
    {
        titleCooldown -= 1;
        if (titleCooldown < 0)
        {
            levelTitle.SetActive(false);
        }
    }
}
