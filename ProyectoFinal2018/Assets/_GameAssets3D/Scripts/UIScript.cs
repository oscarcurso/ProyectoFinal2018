﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {
    [SerializeField] Text txtMaxPuntuacion;
    [SerializeField] GameObject btnEscena2;
    int maxPunt = GameControllerPPref.GetPuntos();
	// Use this for initialization
	void Start () {
       btnEscena2.gameObject.SetActive(false);
        int puntos= GameControllerPPref.GetPuntos();
        txtMaxPuntuacion.text = "Maxima Puntuacion: " + maxPunt; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void BotonSeleccionNiveles() {
        SceneManager.LoadScene(1);
    }
    public void BotonInicioNivel1()
    {
        SceneManager.LoadScene(2);
    }
    public void BotonInicioNivel2() {
        SceneManager.LoadScene(3);
    }

    public void BotonExit() {
        Application.Quit();
    }

    public void Fincamara()
    {
        SceneManager.LoadScene(5);
    }

  
}
