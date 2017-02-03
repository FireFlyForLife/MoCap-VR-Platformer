using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using HKUECT;

/// <summary>
/// Central game manager used for effects when the player needs to fall down.
/// </summary>
public class GameManager : MonoBehaviour {
    public float speed = 2;
    public float maxHeight = 8;
    public bool inLava = false;
    public bool canFall = true;
    private GameObject[] lavas;
    private GameObject[] foots;
    private OptiTrackOSCGearVR gearVRTracker;
    public Rigidbody targetRigidbody;

	void Start () {
        lavas = GameObject.FindGameObjectsWithTag("lava"); //for if the lava needs to rise
        foots = GameObject.FindGameObjectsWithTag("foot"); //the foot should fall down as well (though not currently)
        gearVRTracker = GameObject.Find("GearVRTracker").GetComponent<OptiTrackOSCGearVR>(); //OptiTrackOSCGearVR reference for letting the camera fall down
    }
	
	void Update () {
        // when the foot off the platform and in the lava collider, do all the dying effects
        if (canFall && inLava) {
            //MoveLavaUp();
            FallDown();
        }

        //to be able to reset when you fall in the lava you can tap on the gearvr to reset to the handshake scene.
        if (Input.GetButton("Tap")) {
            SceneManager.LoadScene(0);
        }
    }

    //to fall down we set the gearVRTracker's canFall properties to true
    void FallDown() {
        targetRigidbody.isKinematic = false;
        targetRigidbody.useGravity = true;

        gearVRTracker.canFall = true;
        gearVRTracker.ApplyY = false;
    }

    //currently unused, makes the lava rise on death
    void MoveLavaUp() {
        foreach (GameObject lava in lavas) {
            if (lava.transform.position.y < maxHeight)
                lava.transform.position += Vector3.up * speed * Time.deltaTime;
        }
    }

    public void OnDeath() {
        inLava = true;
    }
}
