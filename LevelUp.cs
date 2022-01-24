﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUp : MonoBehaviour
{
    [SerializeField]private string newLevel;
    // Start is called before the first frame update
    void OnTriggerEnter2D (Collider2D Other)
    {
        if(Other.CompareTag("Player"))
        {
            SceneManager.LoadScene(newLevel);
        }
    }

}
