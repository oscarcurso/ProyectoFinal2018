using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float speed = 5;
    private Animator miAnimator;
    void Start() {
        miAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.W)) {
            miAnimator.SetBool("Andando", true);
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);

        } else {
            transform.Translate(new Vector3(0, 0, 0) * Time.deltaTime * speed);
        }
        
        if (Input.GetKeyDown(KeyCode.S)) {

            miAnimator.SetBool("Andando", false);
        }

        if (Input.GetKeyDown(KeyCode.P)) {
            miAnimator.SetTrigger("Punch");
        }
    }
}
