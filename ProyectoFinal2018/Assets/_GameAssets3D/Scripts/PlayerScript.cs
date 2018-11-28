using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float speed = 1;
    private Animator miAnimator;


    void Start() {
        miAnimator = GetComponent<Animator>();
    }


    void Update() {
        if (Input.GetKey(KeyCode.W)) {
            miAnimator.SetBool("Saltando", false);
            miAnimator.SetBool("Andando", true);
            transform.Translate(new Vector3(0, 0, 2) * Time.deltaTime * speed);

        } else {
            miAnimator.SetBool("Saltando", false);
            miAnimator.SetBool("Andando", false);
            transform.Translate(new Vector3(0, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) {
            miAnimator.SetBool("Saltando", false);
            miAnimator.SetBool("Andando", true);
            transform.Rotate(0, -2, 0);
           

        }
        if (Input.GetKey(KeyCode.D)) {
            miAnimator.SetBool("Saltando", false);
            miAnimator.SetBool("Andando", true);
            transform.Rotate(0, 2, 0);
           
        }
        if (Input.GetKeyDown(KeyCode.Space)) {

            miAnimator.SetBool("Saltando", true);



        }
        if (Input.GetMouseButtonDown(0)) {
            miAnimator.SetTrigger("Punch");
        }



    }
}
       
       
    

