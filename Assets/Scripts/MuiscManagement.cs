using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuiscManagement : MonoBehaviour
{
    // Start is called before the first frame update
    public int whichTrackIsBeingPlayed;
    public int whichAmbientTrack;

    public GameObject drifted;
    public GameObject chase;

    public StalkerMovement sm;
    public BlobMovement bm;
    public InfectedMovement im;
    public GruntMovement gm;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TrackChecker();
        if (sm.isChasing == true || bm.isChasing == true || im.isChasing == true || gm.isChasing == true)
        {
            whichTrackIsBeingPlayed = 1;
            
        } else
        {
            if (whichAmbientTrack == 1)
            {
                whichTrackIsBeingPlayed = 2;
            }
        }
    }

    public void TrackChecker()
    {
        if (whichTrackIsBeingPlayed == 1)
        {
            chase.SetActive(true);
            drifted.SetActive(false);
        }
        if (whichTrackIsBeingPlayed == 2)
        {
            chase.SetActive(false);
            drifted.SetActive(true);
        }


    }
}
