using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{

 public AudioSource HitSound;
    void OnTriggerEnter2D (Collider2D col)
    {
        GameControlScript.health -= 1;
        HitSound.Play();
    }

    
}
