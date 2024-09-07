using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTitle : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject levelTitle;
    private int titleCooldown = 200;

    void Start()
    {
        levelTitle.SetActive(true);
        

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
