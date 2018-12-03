using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunyoScript : MonoBehaviour {
    public Animator elvisAnimator;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.name == "Elvis") {
            print("colision Elvis");

            elvisAnimator.SetBool("ostiado", true);

        }
    }
}
