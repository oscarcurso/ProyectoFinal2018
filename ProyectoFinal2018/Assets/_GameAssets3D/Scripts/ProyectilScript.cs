using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ProyectilScript : MonoBehaviour {

    [SerializeField] Text txtPuntos;
    [SerializeField] Text txtVida;
   


    private void Start() {
        // AudioSource audioSource = new AudioSource();
        //audioSource.Play();
        

        Invoke("Destroy", 5);
    }

    private void OnTriggerEnter(Collider other) {
        GameObject objetivoImpacto = other.gameObject;
      
        if (objetivoImpacto.CompareTag("Enemigo"))
        {
            Debug.Log("Impacto Enemigo");


            objetivoImpacto.GetComponent<Animator>().SetBool("ostiado", true);
            objetivoImpacto.GetComponent<Enemigostontos>().Destruir();
          //  AumentarPuntos();

        }
        Destroy(this.gameObject);


        if (objetivoImpacto.CompareTag("Terrain")) {


            Destroy(this.gameObject);
        }
    }

    public void AumentarPuntos(int punto)
    {
        punto = 1;
        txtPuntos.text = "Puntos: " + punto;
    }




}
