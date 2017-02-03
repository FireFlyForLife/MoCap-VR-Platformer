using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Unused class intended for when you die to let you face the lava
/// does not function
/// </summary>
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
