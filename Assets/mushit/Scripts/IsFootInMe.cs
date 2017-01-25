using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IsFootInMe : MonoBehaviour {

	void Start () {

	}
	
	void Update () {
		
	}

    void OnTriggerEnter(Collider other) {
        Debug.Log("Foot:'" + other.gameObject.name + "'");
        if (other.tag.Equals("foot")) {
            Debug.Log("Foot:'" + other.gameObject.name + "' is in the wine!");
        }
    }
}
