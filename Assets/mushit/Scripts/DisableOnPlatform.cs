using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Utility behaviour to make a object disapear when building for a certain platform
/// Currently supports android and editor toggles.
/// </summary>
public class DisableOnPlatform : MonoBehaviour {
    public bool android = false;
    public bool editor = false;

	void Start () {
#if UNITY_ANDROID
        if (android) enabled = false;
#endif
#if UNITY_EDITOR
        if (editor) enabled = false;
#endif
    }
}
