using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookDown : MonoBehaviour {
    public new Camera camera = null;
    public bool lookDown = false;

	void Start () {
        if(camera == null)
            camera = GetComponent<Camera>();
	}
	
	void Update () {
        if (!lookDown)
            return;

        //Quaternion current = gameObject.transform.rotation;
        //Quaternion target = Vector3.down
	}
}
