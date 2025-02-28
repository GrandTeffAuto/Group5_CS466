using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Transform VRcamera;
    public Transform cameraBody;
    public Transform PlayerBody;
    public float x, y, z;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerBody.transform.rotation = Quaternion.Euler(0, VRcamera.transform.rotation.eulerAngles.y, VRcamera.transform.rotation.eulerAngles.z);

        cameraBody.position = PlayerBody.position + new Vector3(x, y, z);

    }
}
