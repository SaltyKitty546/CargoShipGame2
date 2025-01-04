using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectedAudio : MonoBehaviour
{
    // Start is called before the first frame update
    public InfectedMovement im;

    public AudioSource chaseSound1;
    public AudioSource chaseSound2;
    public AudioSource chaseSound3;
    public AudioSource chaseSound4;
    public AudioSource chaseSound5;

    public AudioSource idleSound1;
    public AudioSource idleSound2;
    public AudioSource idleSound3;
    public AudioSource idleSound4;
    public AudioSource idleSound5;

    public AudioSource ambientSound1;
    public AudioSource ambientSound2;
    public AudioSource ambientSound3;

    public AudioSource bibleSound1;
    public AudioSource bibleSound2;
    public AudioSource bibleSound3;
    public AudioSource bibleSound4;
    public AudioSource bibleSound5;

    public GameObject chaseLoop;

    public int whichBibleSound;
    public int bibleSoundCooldown;

    public int whichChaseSound;
    public int chaseSoundCooldown;

    public int whichIdleSound;
    public int idleSoundCooldown;

    public int whichAmbientSound;
    public int ambientSoundCooldown;

    public int b;
    public int c;
    public int i;
    public int a;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bibleSoundCooldown -= 2;
        chaseSoundCooldown -= 2;
        idleSoundCooldown -= 2;
        ambientSoundCooldown -= 2;

        if (im.isChasing == true)
        {
            chaseLoop.SetActive(true);
            if (chaseSoundCooldown < 0)
            {
                PlayChaseSound();
                chaseSoundCooldown = c;
            }
            if (bibleSoundCooldown < 0)
            {
                PlayBiblicalSound();
                bibleSoundCooldown = b;
            }
        } else
        {
            chaseLoop.SetActive(false);
            if (idleSoundCooldown < 0)
            {
                PlayIdleSound();
                idleSoundCooldown = i;
            }
        }
        if (ambientSoundCooldown < 0)
        {
            PlayAmbientSound();
            ambientSoundCooldown = a;
        }

    }

    public void PlayAmbientSound()
    {
        whichAmbientSound = Random.Range(1, 3);
        if (whichAmbientSound == 1)
        {
            ambientSound1.Play();
        }
        else if (whichAmbientSound == 2)
        {
            ambientSound2.Play();
        }
        else if (whichAmbientSound == 3)
        {
            ambientSound3.Play();
        }
        whichAmbientSound = 0;
    }
    public void PlayIdleSound()
    {
        whichIdleSound = Random.Range(1, 5);
        if (whichIdleSound == 1)
        {
             idleSound1.Play();
        }
        else if (whichIdleSound == 2)
        {
            idleSound2.Play();
        }
        else if (whichIdleSound == 3)
        {
            idleSound3.Play();
        }
        else if (whichIdleSound == 4)
        {
            idleSound4.Play();
        }
        else if (whichIdleSound == 5)
        {
            idleSound5.Play();
        }
        whichIdleSound = 0;
    }
    public void PlayChaseSound()
    {
        whichChaseSound = Random.Range(1, 5);
        if (whichChaseSound == 1)
        {
            chaseSound1.Play();
        } else if (whichChaseSound == 2)
        {
            chaseSound2.Play();
        } else if (whichChaseSound == 3)
        {
            chaseSound3.Play();
        } else if (whichChaseSound == 4)
        {
            chaseSound4.Play();
        } else if (whichChaseSound == 5)
        {
            chaseSound5.Play();
        }
        whichChaseSound = 0;
    }
    public void PlayBiblicalSound()
    {
        whichBibleSound = Random.Range(1, 5);
        if (whichBibleSound == 1)
        {
            bibleSound1.Play();
        }
        else if (whichBibleSound == 2)
        {
            bibleSound2.Play();
        }
        else if (whichBibleSound == 3)
        {
            bibleSound3.Play();
        }
        else if (whichBibleSound == 4)
        {
            bibleSound4.Play();
        }
        else if (whichBibleSound == 5)
        {
            bibleSound5.Play();
        }
        whichBibleSound = 0;
    }
}
