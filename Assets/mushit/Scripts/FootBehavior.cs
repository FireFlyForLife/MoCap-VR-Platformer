using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootBehavior : MonoBehaviour {
    public bool isInStep = false;
    public bool isInLava = false;
    GameManager gameManager;
    new Rigidbody rigidbody;

    void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        rigidbody = gameObject.GetComponentInParent<Rigidbody>();
	}
	
	void Update () {
        if(!isInStep && isInLava) {
            gameManager.OnDeath();
            rigidbody.isKinematic = false;
        }
    }
    
    private void OnTriggerEnter(Collider other) {
        if (other.tag.Equals("step")) {
            Debug.Log(gameObject.name + " hit " + other.transform.parent.name);
            isInStep = true;
        }else if (other.tag.Equals("lava")) {
            Debug.Log(gameObject.name + " hit " + other.name);
            isInLava = true;
        }
    }

    private void OnTriggerStay(Collider other) {
        //if (other.tag.Equals("lava")) {
        //    Debug.Log(gameObject.name + " hit " + other.name);
        //    isInLava = true;
        //}
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag.Equals("step")) {
            Debug.Log(gameObject.name + " out of " + other.name);
            isInStep = false;
        }else if (other.tag.Equals("lava")) {
            isInLava = false;
        }
    }
}
