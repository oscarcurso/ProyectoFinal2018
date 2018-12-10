using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PunyoScript : MonoBehaviour {

    public Animator elvisAnimator;
    public NavMeshAgent agenteElvis;
    public Animator abuelaAnimator;
    public NavMeshAgent agenteAbuela;
    public Animator chicaAnimator;
    public NavMeshAgent agenteChica;

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
        if (collider.gameObject.name == "Abuela") {
            print("colision Abuela");

            abuelaAnimator.SetBool("ostiado", true);
            agenteAbuela.Stop();

        }
        if (collider.gameObject.name == "Chica") {
            print("colision Chica");

            chicaAnimator.SetBool("ostiado", true);
            agenteChica.Stop();

        }
    } 

   
}
