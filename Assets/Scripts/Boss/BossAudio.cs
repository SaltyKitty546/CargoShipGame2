using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAudio : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource roar1;
    public AudioSource roar2;
    public AudioSource roar3;
    public AudioSource roar4;
    public int roarCooldown;
    public int roarSoundCooldown;
    
    public int bibleSoundCooldown;
    public int bibleSoundCooldownReset;

    public AudioSource[] bibleSounds;

    void Start()
    {
        bibleSoundCooldown = 400;
    }

    // Update is called once per frame
    void Update()
    {
        roarCooldown -= 1;
        bibleSoundCooldown -= 1;
        if (roarCooldown < 0) {
            GenerateRoarSound();
            roarCooldown = roarSoundCooldown;
        }
        if (bibleSoundCooldown < 0) {
            bibleSounds[Random.Range(0, bibleSounds.Length - 1)].Play();
            bibleSoundCooldown = bibleSoundCooldownReset;
        }
    }

    public void GenerateRoarSound() {
        int randomSound = Random.Range(1, 4);
        if (randomSound == 1) {
            roar1.Play();
        } else if (randomSound == 2) {
            roar2.Play();
        } else if (randomSound == 3) {
            roar3.Play();
        } else if (randomSound == 4) {
            roar4.Play();
        }
    }

}
