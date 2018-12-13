using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ProyectilScript : MonoBehaviour {
   
    


    private void Start() {
        // AudioSource audioSource = new AudioSource();
        //audioSource.Play();


        Invoke("Destroy", 5);
    }

    private void OnTriggerEnter(Collider other) {
        GameObject objetivoImpacto = other.gameObject;
      
        if (objetivoImpacto.CompareTag("Enemigo")) {
            Debug.Log("Impacto  Enemigo");

           
            objetivoImpacto.GetComponent<Animator>().SetBool("ostiado", true);
            


            
        } 
        Destroy(this.gameObject);


        if (objetivoImpacto.CompareTag("Terrain")) {


            Destroy(this.gameObject);
        }
    }



   

}
