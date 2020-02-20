using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CameraFocus : MonoBehaviour
{
    private bool VuforiaLaunched = false;

    void Start()
    {
        VuforiaARController vuforia = VuforiaARController.Instance;

        if (vuforia != null)
            vuforia.RegisterVuforiaStartedCallback(StartAfterVuforia);
    }

    private void StartAfterVuforia()
    {
        VuforiaLaunched = true;
        SetAutofocus();
    }

    void OnApplicationPause(bool pause)
    {
        if (!pause)
        {
            // App resumed
            if (VuforiaLaunched)
            {
                SetAutofocus(); 
            }
        }
    }

    private void SetAutofocus()
    {
        if (CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO))
        {
            Debug.Log("Autofocus set");
        }
        else
        {
            Debug.Log("this device doesn't support auto focus");
        }
    }
}
