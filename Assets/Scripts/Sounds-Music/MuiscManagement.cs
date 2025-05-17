using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuiscManagement : MonoBehaviour
{
    
    public AudioSource track1;
    public AudioSource track2;
    public AudioSource track3;
    public int chosenTrack;
    

    void Start()
    {
        ChooseTrack();
    }

    // Update is called once per frame
    void Update()
    {
             
    }

    public void ChooseTrack() {
        chosenTrack = Random.Range(0, 4);
        if (chosenTrack == 1) {
            track1.Play();
        } else {
            if (chosenTrack == 2) {
                track2.Play();
            } else {
                track3.Play();
            }
        }
        Invoke("ChooseTrack", 245f);
        
    }

}
