using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TortaScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Invoke("Destroy", 0.5f);
		
	}

    private void Destroy() {
        Destroy(this.gameObject);
    }
}
