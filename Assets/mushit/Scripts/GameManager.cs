using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using HKUECT;

public class GameManager : MonoBehaviour {
    public float speed = 2;
    public float maxHeight = 8;
    public bool inLava = false;
    public bool canFall = true;
    private GameObject[] lavas;
    private GameObject[] foots;
    private GameObject mainCamera;
    private OptiTrackOSCGearVR gearVRTracker;
    public Rigidbody targetRigidbody;

	// Use this for initialization
	void Start () {
        lavas = GameObject.FindGameObjectsWithTag("lava");
        foots = GameObject.FindGameObjectsWithTag("foot");
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        gearVRTracker = GameObject.Find("GearVRTracker").GetComponent<OptiTrackOSCGearVR>();
    }
	
	// Update is called once per frame
	void Update () {
        if (canFall && inLava) {
            //MoveLavaUp();
            FallDown();
        }

        if (Input.GetButton("Tap")) {
            SceneManager.LoadScene(0);
        }
    }

    void FallDown() {
        targetRigidbody.isKinematic = false;
        targetRigidbody.useGravity = true;
        //mainCamera.transform.SetParent(null);
        gearVRTracker.canFall = true;
        gearVRTracker.ApplyY = false;
    }

    void MoveLavaUp() {
        foreach (GameObject lava in lavas) {
            if (lava.transform.position.y < maxHeight)
                lava.transform.position += Vector3.up * speed * Time.deltaTime;
        }
    }

    public void OnDeath() {
        inLava = true;
        //Camera.main.transform.parent = null;
    }
}
