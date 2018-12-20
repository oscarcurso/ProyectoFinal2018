using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour {


    int speedRotarParado = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Vertical") > 0.1f) {
            transform.Translate(0, 0, 1);
           
        } else {

           
        }


        transform.Rotate(0, Input.GetAxis("Horizontal") * speedRotarParado, 0);

    }


}

       

