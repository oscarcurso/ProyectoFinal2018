using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    Animator miAnimator;
    float corriendo = 0.10f;
    public float speedAndar = 2f;
    public float speedCorrer = 2f;




    void Start() {
        miAnimator = GetComponent<Animator>();
    }


    void Update() {
        if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftShift)) {
            corriendo = corriendo - 0.01f;
            corriendo = Mathf.Max(0.11f, corriendo);
            miAnimator.SetFloat("corriendo", corriendo);
        } else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftShift)) {
            corriendo = corriendo + 0.01f;
            corriendo = Mathf.Min(1, corriendo);
            miAnimator.SetFloat("corriendo", corriendo );
        } else if (!Input.GetKey(KeyCode.UpArrow)) {
            corriendo = corriendo - 0.01f;
            corriendo = Mathf.Max(0f, corriendo);
            miAnimator.SetFloat("corriendo", corriendo);

        }
        if (corriendo > 0.1f) {

            transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
        }
    }
}






