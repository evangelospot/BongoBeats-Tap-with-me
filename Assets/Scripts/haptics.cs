using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class haptics : MonoBehaviour
{
    public SteamVR_Action_Vibration hapticAction;
    public SteamVR_Action_Boolean trackpadAction;

    public float timeDistanceHaptics;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Time.time >= distanceTimeHaptics)
        if (trackpadAction.GetStateDown(SteamVR_Input_Sources.LeftHand))
        {
            //put startTime instead of '1'
            //while for amplitute's increase

            Pulse(1, 150, 75, SteamVR_Input_Sources.LeftHand);
        }

        if (trackpadAction.GetStateDown(SteamVR_Input_Sources.RightHand))
        {
            Pulse(1, 150, 75, SteamVR_Input_Sources.RightHand);
        }
    }


    private void Pulse(float duration, float frequency, float amplitude, SteamVR_Input_Sources source)
    {
        hapticAction.Execute(0, duration, frequency, amplitude, source);

        Debug.Log("Pulse" + " " + source.ToString());
    }
}
