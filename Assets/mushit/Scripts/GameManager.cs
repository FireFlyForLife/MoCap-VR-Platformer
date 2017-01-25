using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public float speed = 2;
    public float maxHeight = 8;
    public bool inLava = false;
    private GameObject[] lavas;

	// Use this for initialization
	void Start () {
        lavas = GameObject.FindGameObjectsWithTag("lava");
	}
	
	// Update is called once per frame
	void Update () {
        if (!inLava)
            return;

        foreach (GameObject lava in lavas) {
            if(lava.transform.position.y < maxHeight)
                lava.transform.position += Vector3.up * speed * Time.deltaTime;
        }
    }

    public void OnDeath() {
        inLava = true;
    }
}
