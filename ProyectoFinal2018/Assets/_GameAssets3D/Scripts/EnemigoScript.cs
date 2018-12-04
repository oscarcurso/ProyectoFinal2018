﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemigoScript : MonoBehaviour {
    // public Text textDTP;
    // public Text textATP;
    // public Text textATiro;
    Animator miAnimator;
    public GameObject player;
    public Transform[] puntosPatrulla = new Transform[5];
    NavMeshAgent agente;
    enum Estado { Idle, Andando, Corriendo, Saltando, Disparando, Siguiendo, Distraido };
    Estado estado = Estado.Idle;
    const int TIEMPO_ESPERA = 1;
    float anguloVision = 25;
    float distanciaVision = 6;


    void Start() {
        agente = GetComponent<NavMeshAgent>();
        AsignarPuntoPatrulla();
        miAnimator = GetComponent<Animator>();
    }
    void Update() {
       
            VerificarObjectivo();
        

        switch (estado) {

           /* case Estado.Idle:
                ComprobarDestino();
                break;*/

            case Estado.Andando:
                miAnimator.SetBool("corriendo", false);
                ComprobarDestino();
                break;

            case Estado.Siguiendo:              
                agente.destination = player.transform.position;
                miAnimator.SetBool("corriendo", true);
                break;

            case Estado.Distraido:
                ComprobarDestino();
                break;
        }
    }

    private void VerificarObjectivo() {
        float distancia = Vector3.Distance(transform.position, player.transform.position);
        Vector3 direccion = Vector3.Normalize(player.transform.position - transform.position);
        float angulo = Vector3.Angle(direccion, transform.forward);
        if (distancia < distanciaVision && angulo < anguloVision) {
            Debug.DrawLine(transform.position, player.transform.position, Color.red, 1);
            RaycastHit rch;
            if (Physics.Raycast(
                transform.position,
                direccion,
                out rch,
                Mathf.Infinity)) {
                if (rch.transform.gameObject.name == "Player") {
                    
                    estado = Estado.Siguiendo;
                } else {
                   // textATiro.text = "A tiro: NO";
                }
            }
        } else {
           // textATiro.text = "A tiro: NO";
        }

        //textDTP.text = "DTP:" + distancia.ToString();
       // textATP.text = "ATP:" + angulo.ToString();
    }

    private void ComprobarDestino() {
        if (!agente.pathPending) {
            if (agente.remainingDistance <= agente.stoppingDistance + 0.1) {
                //animador.SetBool("andando", false);
                estado = Estado.Idle;
                Invoke("AsignarPuntoPatrulla", TIEMPO_ESPERA);
            }
        }
    }
    private void AsignarPuntoPatrulla() {
        if (estado != Estado.Distraido) {
            int pp = Random.Range(0, puntosPatrulla.Length);
            agente.destination = puntosPatrulla[pp].position;
            estado = Estado.Andando;
        }
    }

    public void SetDistraccion(Vector3 position) {
        agente.destination = position;
        estado = Estado.Distraido;
    }

   

}
