﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroScript : MonoBehaviour {
   
  



    private void Awake()
    {
        
    }
    // Use this for initialization
    void Start () {
       

        Invoke("CargarEscena", 4);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void CargarEscena()
    {
        SceneManager.LoadScene(1);
    }
}
