using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PunyoScript : MonoBehaviour {

    public Animator elvisAnimator;
    public NavMeshAgent agenteElvis; 
	
	void Start () {
		
	}
	
	
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collider) {

        if (collider.gameObject.name == "Elvis") {
            print("colision Elvis");

            elvisAnimator.SetBool("ostiado", true);
            agenteElvis.Stop();

        }
    } 

   
}
