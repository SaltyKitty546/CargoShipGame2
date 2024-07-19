using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarManagement : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerHealthControl php;

    public GameObject health100;
    public GameObject health90;
    public GameObject health80;
    public GameObject health70;
    public GameObject health60;
    public GameObject health50;
    public GameObject health40;
    public GameObject health30;
    public GameObject health20;
    public GameObject health10;

    public GameObject hunger10;
    public GameObject hunger9;
    public GameObject hunger8;
    public GameObject hunger7;
    public GameObject hunger6;
    public GameObject hunger5;
    public GameObject hunger4;
    public GameObject hunger3;
    public GameObject hunger2;
    public GameObject hunger1;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (php.health == 100)
        {
            health100.SetActive(true);
            health90.SetActive(true);
            health80.SetActive(true);
            health70.SetActive(true);
            health60.SetActive(true);
            health50.SetActive(true);
            health30.SetActive(true);
            health20.SetActive(true);
            health10.SetActive(true);
            health40.SetActive(true);
        } else if (php.health < 100 && 89 < php.health) {
            health100.SetActive(false);
            health90.SetActive(true);
            health80.SetActive(true);
            health70.SetActive(true);
            health60.SetActive(true);
            health50.SetActive(true);
            health30.SetActive(true);
            health20.SetActive(true);
            health10.SetActive(true);
            health40.SetActive(true);
        } else if (php.health < 90 && 79 < php.health)
        {
            health100.SetActive(false);
            health90.SetActive(false);
            health80.SetActive(true);
            health70.SetActive(true);
            health60.SetActive(true);
            health50.SetActive(true);
            health30.SetActive(true);
            health20.SetActive(true);
            health10.SetActive(true);
            health40.SetActive(true);
        } else if (php.health < 80 && 69 < php.health)
        {
            health100.SetActive(false);
            health90.SetActive(false);
            health80.SetActive(false);
            health70.SetActive(true);
            health60.SetActive(true);
            health50.SetActive(true);
            health30.SetActive(true);
            health20.SetActive(true);
            health10.SetActive(true);
            health40.SetActive(true);
        } else if (php.health < 70 && 59 < php.health)
        {
            health100.SetActive(false);
            health90.SetActive(false);
            health80.SetActive(false);
            health70.SetActive(false);
            health60.SetActive(true);
            health50.SetActive(true);
            health30.SetActive(true);
            health20.SetActive(true);
            health10.SetActive(true);
            health40.SetActive(true);
        } else if (php.health < 60 && 49 < php.health)
        {
            health100.SetActive(false);
            health90.SetActive(false);
            health80.SetActive(false);
            health70.SetActive(false);
            health60.SetActive(false);
            health50.SetActive(true);
            health30.SetActive(true);
            health20.SetActive(true);
            health10.SetActive(true);
            health40.SetActive(true);
        } else if (php.health < 50 && 39 < php.health)
        {
            health100.SetActive(false);
            health90.SetActive(false);
            health80.SetActive(false);
            health70.SetActive(false);
            health60.SetActive(false);
            health50.SetActive(false);
            health30.SetActive(true);
            health20.SetActive(true);
            health10.SetActive(true);
            health40.SetActive(true);
        } else if (php.health < 40 && 29 < php.health)
        {
            health100.SetActive(false);
            health90.SetActive(false);
            health80.SetActive(false);
            health70.SetActive(false);
            health60.SetActive(false);
            health50.SetActive(false);
            health30.SetActive(true);
            health20.SetActive(true);
            health10.SetActive(true);
            health40.SetActive(false);
        } else if (php.health < 30 && 19 < php.health)
        {
            health100.SetActive(false);
            health90.SetActive(false);
            health80.SetActive(false);
            health70.SetActive(false);
            health60.SetActive(false);
            health50.SetActive(false);
            health30.SetActive(false);
            health20.SetActive(true);
            health10.SetActive(true);
            health40.SetActive(false);
        } else if (php.health < 20 && 9 < php.health)
        {
            health100.SetActive(false);
            health90.SetActive(false);
            health80.SetActive(false);
            health70.SetActive(false);
            health60.SetActive(false);
            health50.SetActive(false);
            health30.SetActive(false);
            health20.SetActive(false);
            health10.SetActive(true);
            health40.SetActive(false);
        } else if (php.health < 10)
        {
            health100.SetActive(false);
            health90.SetActive(false);
            health80.SetActive(false);
            health70.SetActive(false);
            health60.SetActive(false);
            health50.SetActive(false);
            health30.SetActive(false);
            health20.SetActive(false);
            health10.SetActive(true);
            health40.SetActive(false);
        } else
        {
            health100.SetActive(false);
            health90.SetActive(false);
            health80.SetActive(false);
            health70.SetActive(false);
            health60.SetActive(false);
            health50.SetActive(false);
            health30.SetActive(false);
            health20.SetActive(false);
            health10.SetActive(false);
            health40.SetActive(false);
        }

        if (php.hungerLevel == 10)
        {
            hunger10.SetActive(true);
            hunger9.SetActive(true);
            hunger8.SetActive(true);
            hunger7.SetActive(true);
            hunger6.SetActive(true);
            hunger5.SetActive(true);
            hunger4.SetActive(true);
            hunger3.SetActive(true);
            hunger2.SetActive(true);
            hunger1.SetActive(true);
        } else if (php.hungerLevel == 9)
        {
            hunger10.SetActive(false);
            hunger9.SetActive(true);
            hunger8.SetActive(true);
            hunger7.SetActive(true);
            hunger6.SetActive(true);
            hunger5.SetActive(true);
            hunger4.SetActive(true);
            hunger3.SetActive(true);
            hunger2.SetActive(true);
            hunger1.SetActive(true);
        } else if (php.hungerLevel == 8)
        {
            hunger10.SetActive(false);
            hunger9.SetActive(false);
            hunger8.SetActive(true);
            hunger7.SetActive(true);
            hunger6.SetActive(true);
            hunger5.SetActive(true);
            hunger4.SetActive(true);
            hunger3.SetActive(true);
            hunger2.SetActive(true);
            hunger1.SetActive(true);
        } else if (php.hungerLevel == 7)
        {
            hunger10.SetActive(false);
            hunger9.SetActive(false);
            hunger8.SetActive(false);
            hunger7.SetActive(true);
            hunger6.SetActive(true);
            hunger5.SetActive(true);
            hunger4.SetActive(true);
            hunger3.SetActive(true);
            hunger2.SetActive(true);
            hunger1.SetActive(true);
        } else if (php.hungerLevel == 6)
        {
            hunger10.SetActive(false);
            hunger9.SetActive(false);
            hunger8.SetActive(false);
            hunger7.SetActive(false);
            hunger6.SetActive(true);
            hunger5.SetActive(true);
            hunger4.SetActive(true);
            hunger3.SetActive(true);
            hunger2.SetActive(true);
            hunger1.SetActive(true);
        } else if (php.hungerLevel == 5)
        {
            hunger10.SetActive(false);
            hunger9.SetActive(false);
            hunger8.SetActive(false);
            hunger7.SetActive(false);
            hunger6.SetActive(false);
            hunger5.SetActive(true);
            hunger4.SetActive(true);
            hunger3.SetActive(true);
            hunger2.SetActive(true);
            hunger1.SetActive(true);
        } else if (php.hungerLevel == 4)
        {
            hunger10.SetActive(false);
            hunger9.SetActive(false);
            hunger8.SetActive(false);
            hunger7.SetActive(false);
            hunger6.SetActive(false);
            hunger5.SetActive(false);
            hunger4.SetActive(true);
            hunger3.SetActive(true);
            hunger2.SetActive(true);
            hunger1.SetActive(true);
        } else if (php.hungerLevel == 3)
        {
            hunger10.SetActive(false);
            hunger9.SetActive(false);
            hunger8.SetActive(false);
            hunger7.SetActive(false);
            hunger6.SetActive(false);
            hunger5.SetActive(false);
            hunger4.SetActive(false);
            hunger3.SetActive(true);
            hunger2.SetActive(true);
            hunger1.SetActive(true);
        } else if (php.hungerLevel == 2)
        {
            hunger10.SetActive(false);
            hunger9.SetActive(false);
            hunger8.SetActive(false);
            hunger7.SetActive(false);
            hunger6.SetActive(false);
            hunger5.SetActive(false);
            hunger4.SetActive(false);
            hunger3.SetActive(false);
            hunger2.SetActive(true);
            hunger1.SetActive(true);
        } else if (php.hungerLevel == 1)
        {
            hunger10.SetActive(false);
            hunger9.SetActive(false);
            hunger8.SetActive(false);
            hunger7.SetActive(false);
            hunger6.SetActive(false);
            hunger5.SetActive(false);
            hunger4.SetActive(false);
            hunger3.SetActive(false);
            hunger2.SetActive(false);
            hunger1.SetActive(true);
        } else if (php.hungerLevel == 0)
        {
            hunger10.SetActive(false);
            hunger9.SetActive(false);
            hunger8.SetActive(false);
            hunger7.SetActive(false);
            hunger6.SetActive(false);
            hunger5.SetActive(false);
            hunger4.SetActive(false);
            hunger3.SetActive(false);
            hunger2.SetActive(false);
            hunger1.SetActive(false);
        }
    } 
}
