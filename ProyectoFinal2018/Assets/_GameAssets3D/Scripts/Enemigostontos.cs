using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemigostontos : MonoBehaviour {

    [SerializeField]  int tiempoEntreRotacion = 2;
    [SerializeField] int inicioRotacion = 1;
    [SerializeField] ProyectilScript scriptProyectil;
   






    void Start() {
       
        
        InvokeRepeating("RotarAleatoriamente", inicioRotacion, tiempoEntreRotacion);

    }

     void Update() {

        Avanzar();
       
        

    }
    public void RotarAleatoriamente() {
        float rotacion = Random.Range(0f, 360f);

        transform.eulerAngles = new Vector3(0, rotacion, 0);
    }

    public void Avanzar() {

        int speed = 1;
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        

    }





  
    public void Destruir()
    {
        Destroy(this);
    }

   /*public void SumarPuntos() {

        txtPuntos.text = "Puntos: " + puntos + 1;
    }*/


}

   

