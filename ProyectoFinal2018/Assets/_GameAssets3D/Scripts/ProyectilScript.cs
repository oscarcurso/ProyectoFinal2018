using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ProyectilScript : MonoBehaviour {

    [SerializeField] Text txtPuntos;
    [SerializeField] Text txtVida;
  
    int puntos = 0;



    private void Start() {




        Invoke("Destroy", 5);
    }

    private void OnTriggerEnter(Collider other) {
        GameObject objetivoImpacto = other.gameObject;

        if (objetivoImpacto.CompareTag("Enemigo")) {
            Debug.Log("Impacto Enemigo");


            objetivoImpacto.GetComponent<Animator>().SetBool("ostiado", true);
            
            objetivoImpacto.GetComponent<Enemigostontos>().Destruir();








        }

        Destroy(this.gameObject);



        if (objetivoImpacto.CompareTag("Terrain")) {


            Destroy(this.gameObject);
        }
    }


    private void OnDestroy() {
       
    }



}
