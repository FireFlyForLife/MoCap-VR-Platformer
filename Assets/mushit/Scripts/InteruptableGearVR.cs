using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HKUECT;

/// <summary>
/// intended to be able to make the vr player fall down, turns out that can be done with OptiTrackerOSCGearVR#canFall
/// </summary>
public class InteruptableGearVR : OptiTrackOSCGearVR {
    public bool ApplyX { get; set; }
    public bool ApplyY { get; set; }
    public bool ApplyZ { get; set; }

    protected override void Awake() {
        base.Awake();
        ApplyX = true;
        ApplyY = true;
        ApplyZ = true;
    }

    protected override void ApplyTransformUpdate(Vector3 position, Quaternion rotation) {
        base.ApplyTransformUpdate(position, rotation);
    }
}
