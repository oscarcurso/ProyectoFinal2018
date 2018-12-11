using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PunyoScript : MonoBehaviour {

    public Animator elvisAnimator1;
    public NavMeshAgent agenteElvis1;
    public Animator elvisAnimator2;
    public NavMeshAgent agenteElvis2;
    public Animator elvisAnimator3;
    public NavMeshAgent agenteElvis3;
    public Animator abuelaAnimator1;
    public NavMeshAgent agenteAbuela1;
    public Animator abuelaAnimator2;
    public NavMeshAgent agenteAbuela2;
    public Animator abuelaAnimator3;
    public NavMeshAgent agenteAbuela3;
    public Animator abuelaAnimator4;
    public NavMeshAgent agenteAbuela4;
    public Animator chicaAnimator1;
    public NavMeshAgent agenteChica1;
    public Animator chicaAnimator2;
    public NavMeshAgent agenteChica2;
    public Animator chicaAnimator3;
    public NavMeshAgent agenteChica3;
    void Start () {
		
	}
	
	
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collider) {

        if (collider.gameObject.name == "Elvis1") {
            print("colision Elvis1");

            elvisAnimator1.SetBool("ostiado", true);
            agenteElvis1.isStopped =true;

        }
        if (collider.gameObject.name == "Elvis2") {
            print("colision Elvis2");

            elvisAnimator2.SetBool("ostiado", true);
            agenteElvis2.isStopped = true;

        }
        if (collider.gameObject.name == "Elvis3") {
            print("colision Elvis3");

            elvisAnimator3.SetBool("ostiado", true);
            agenteElvis3.isStopped = true;

        }

        
        if (collider.gameObject.name == "Abuela1") {
            print("colision Abuela1");

            abuelaAnimator1.SetBool("ostiado", true);
            agenteAbuela1.isStopped = true;

        }
        if (collider.gameObject.name == "Abuela2") {
            print("colision Abuela2");

            abuelaAnimator2.SetBool("ostiado", true);
            agenteAbuela2.isStopped = true;

        }
        if (collider.gameObject.name == "Abuela3") {
            print("colision Abuela3");

            abuelaAnimator3.SetBool("ostiado", true);
            agenteAbuela3.isStopped = true;

        }
        if (collider.gameObject.name == "Abuela4") {
            print("colision Abuela4");

            abuelaAnimator4.SetBool("ostiado", true);
            agenteAbuela4.isStopped = true;

        }
        if (collider.gameObject.name == "Chica1") {
            print("colision Chica1");

            chicaAnimator1.SetBool("ostiado", true);
            agenteChica1.isStopped = true;

        }
        if (collider.gameObject.name == "Chica2") {
            print("colision Chica2");

            chicaAnimator2.SetBool("ostiado", true);
            agenteChica2.isStopped = true;

        }
        if (collider.gameObject.name == "Chica3") {
            print("colision Chica3");

            chicaAnimator3.SetBool("ostiado", true);
            agenteChica3.isStopped = true;

        }
    } 

   
}
