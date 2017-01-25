using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TriggersWith : MonoBehaviour {
    public String targetTag;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other) {
        //Debug.Log(gameObject.name + ":'" + other.gameObject.name + "'");
        if (other.tag.Equals(targetTag)) {
            Debug.Log(gameObject.name + " hit "+ other.name);
        }
    }
}
