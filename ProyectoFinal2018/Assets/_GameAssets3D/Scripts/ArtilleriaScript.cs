using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtilleriaScript : MonoBehaviour {

    private float speed = 200.0f;
    [SerializeField] GameObject prefabProyectil;
    [SerializeField] Transform puntoGeneracion;
    //[SerializeField] Rigidbody proyectil;
    public float fuerza = 100;




    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {


        if (Input.GetMouseButtonDown(0)) {
           GameObject nuevoProyectil = Instantiate(prefabProyectil, puntoGeneracion.transform.position, puntoGeneracion.transform.rotation);
            nuevoProyectil.GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * fuerza);
        }



        float rotationY = Input.GetAxis("Vertical") * speed;
        float rotationX = Input.GetAxis("Horizontal") * speed;


        rotationY *= Time.deltaTime;
        rotationX *= Time.deltaTime;


        transform.Rotate(rotationY, 0, 0);


        transform.Rotate(0, rotationX, 0);


    }
   
}
