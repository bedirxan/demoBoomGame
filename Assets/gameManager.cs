﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour
{
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    public void restarted()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void menuyeDon()
    {
        SceneManager.LoadScene("AnaMenu");
    }
}
