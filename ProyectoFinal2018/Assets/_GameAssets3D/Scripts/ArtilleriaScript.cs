using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtilleriaScript : MonoBehaviour {

    private float speed = 200.0f;
    [SerializeField] Rigidbody prefabProyectil;
    [SerializeField] Transform puntoGeneracion;
    //[SerializeField] Rigidbody proyectil;
    int fuerza = 3;




    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {


        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(prefabProyectil, puntoGeneracion.up, Quaternion.identity);
            prefabProyectil.AddRelativeForce(0, 0, fuerza);
        }



        float rotationY = Input.GetAxis("Vertical") * speed;
        float rotationX = Input.GetAxis("Horizontal") * speed;


        rotationY *= Time.deltaTime;
        rotationX *= Time.deltaTime;


        transform.Rotate(rotationY, 0, 0);


        transform.Rotate(0, rotationX, 0);


    }
}
