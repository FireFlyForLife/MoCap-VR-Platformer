using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootBehavior : MonoBehaviour {
    public bool isInStep = false;

    void Start () {
		
	}
	
	void Update () {
        
    }
    
    private void OnTriggerEnter(Collider other) {
        if (other.tag.Equals("step")) {
            Debug.Log(gameObject.name + " hit " + other.transform.parent.name);
            isInStep = true;
        }else if (other.tag.Equals("lava") && !isInStep) {
            Debug.Log(gameObject.name + " hit " + other.name);
        }
    }

    private void OnTriggerStay(Collider other) {
        if (other.tag.Equals("lava") && !isInStep) {
            Debug.Log(gameObject.name + " hit " + other.name);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag.Equals("step")) {
            Debug.Log(gameObject.name + " out of " + other.name);
            isInStep = false;
        }
    }
}
