using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnPlatform : MonoBehaviour {
    public bool android = false;
    public bool editor = false;

	// Use this for initialization
	void Start () {
#if UNITY_ANDROID
        if (android) enabled = false;
#endif
#if UNITY_EDITOR
        if (editor) enabled = false;
#endif
    }

    // Update is called once per frame
    void Update () {
		
	}
}
