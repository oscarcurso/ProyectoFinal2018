﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunyoScript : MonoBehaviour {
    public Animator elvisAnimator;
	
	void Start () {
		
	}
	
	
	void Update () {
		
	}
    private void OnTriggerEnter(Collider collision) {

        if (collision.gameObject.tag == "Elvis") {
            print("colision Elvis");

            elvisAnimator.SetBool("ostiado", true);

        }
    }
}
