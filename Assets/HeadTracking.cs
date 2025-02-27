//VR HEAD TRACKING CONTROLLER
//This script is responsible for enabling camera movement with
//mobile device directional movement.

//imports
using UnityEngine;

public class HeadTracking : MonoBehaviour
{
    void Start()
    {
        Input.gyro.enabled = true; // Enable Gyroscope for phone if not
    }

    void Update()
    {
        if (SystemInfo.supportsGyroscope)
        {
            Quaternion deviceRotation = Input.gyro.attitude;
            transform.rotation = Quaternion.Euler(90f, 0f, 0f) * new Quaternion(deviceRotation.x, deviceRotation.y, -deviceRotation.z, -deviceRotation.w);
        }
    }
}
