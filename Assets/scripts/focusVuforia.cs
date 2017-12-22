using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class focusVuforia : MonoBehaviour {

    // Contains the currently set auto focus mode.
    public CameraDevice.FocusMode mFocusMode = CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO;

    void Awake()
    {
        CameraDevice.Instance.SetFocusMode(mFocusMode);
    }
}
