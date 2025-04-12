using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuiscManagement : MonoBehaviour
{
    
    public AudioSource track1;
    public AudioSource track2;
    public AudioSource track3;

    public int musicCooldown = 0;
    public int chosenTrack;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        musicCooldown -= 1;
        if (musicCooldown < 0)
        {
            ChooseTrack();
        }
        
    }

    public void ChooseTrack()
    {
        chosenTrack = Random.Range(1, 3);
        musicCooldown = 17000;
        track1.Stop();
        track2.Stop();
        track3.Stop();

        if (chosenTrack == 1)
        {
            track1.Play();
        } else if (chosenTrack == 2)
        {
            track2.Play();
        } else if (chosenTrack == 3)
        {
            track3.Play();
        }
    }
}
