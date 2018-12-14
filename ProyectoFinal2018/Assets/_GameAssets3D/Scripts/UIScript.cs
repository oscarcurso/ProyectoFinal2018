using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {
    [SerializeField] Text boton2;

	// Use this for initialization
	void Start () {
        boton2.gameObject.SetActive(false);
        int puntos= GameControllerPPref.GetPuntos();
        boton2.text = "Maximo Puntuacion: " + puntos; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void BotonInicioNivel1() {
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
