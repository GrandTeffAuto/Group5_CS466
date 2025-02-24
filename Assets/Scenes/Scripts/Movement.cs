using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Transform player;

    public float lookDownAngle = 10.0f;

    public float playerSpeed = 1.0f;

    public bool moveForward;

    private CharacterController cc;


    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {       
        if (player.eulerAngles.x >= lookDownAngle && player.eulerAngles.x < 90.0f)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }

        if (moveForward == true)
        {
            Vector3 forward = player.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * playerSpeed);
        }
    }
}
