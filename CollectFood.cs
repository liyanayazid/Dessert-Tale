using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//collect
public class CollectFood : MonoBehaviour
{

    public AudioSource collectSound;
    void OnTriggerEnter2D(Collider2D collision){
        collectSound.Play();
        ScoringSystem.theScore += 50;
        Destroy(gameObject);
    }
}
