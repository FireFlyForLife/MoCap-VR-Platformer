using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public float speed = 2;
    public float maxHeight = 8;
    public bool inLava = false;
    private GameObject[] lavas;
    private GameObject[] foots;
    private GameObject mainCamera;

	// Use this for initialization
	void Start () {
        lavas = GameObject.FindGameObjectsWithTag("lava");
        foots = GameObject.FindGameObjectsWithTag("foot");
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
        if (inLava) {
            //MoveLavaUp();
            FallDown();
        }
    }

    void FallDown() {
        mainCamera.GetComponent<Rigidbody>().isKinematic = false;
        mainCamera.transform.SetParent(null);
    }

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
