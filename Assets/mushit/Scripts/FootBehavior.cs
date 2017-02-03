using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class for the foot, makes sure that when the foot is not on the platform, 
/// you will fall down.
/// </summary>
public class FootBehavior : MonoBehaviour {
    public bool isInStep = false;
    public bool isInLava = false;
    GameManager gameManager;
    new Rigidbody rigidbody;

    void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        rigidbody = gameObject.GetComponentInParent<Rigidbody>();
	}
	
    //When the foot is not on a platform but is in the lava trigger, fall down in the lava!
	void Update () {
        if(!isInStep && isInLava) {
            gameManager.OnDeath();
            rigidbody.isKinematic = false;
        }
    }
    
    //register that we are in the lava collider or a stepping stone
    private void OnTriggerEnter(Collider other) {
        if (other.tag.Equals("step")) {
            Debug.Log(gameObject.name + " hit " + other.transform.parent.name);
            isInStep = true;
        }else if (other.tag.Equals("lava")) {
            Debug.Log(gameObject.name + " hit " + other.name);
            isInLava = true;
        }
    }

    //register that we are not in the lava collider or a stepping stone
    private void OnTriggerExit(Collider other) {
        if (other.tag.Equals("step")) {
            Debug.Log(gameObject.name + " out of " + other.name);
            isInStep = false;
        }else if (other.tag.Equals("lava")) {
            isInLava = false;
        }
    }
}
