//PLAYER MOVEMENT HANDLER SCRIPT
//This is responsible for the player moving forward when
//input is recieved on mobile device



//Imports
using UnityEngine;

public class VRPlayerMovement : MonoBehaviour
{
    public float moveSpeed = 2.5f; // Walking speed
    private CharacterController characterController; // Object for player controller
    private bool isMoving = false; // Toggle movement
    public bool movementEnabled = true; // Allow movement control externally for when in a learning area.. 

    void Start()
    {
        characterController = GetComponent<CharacterController>();

        if (characterController == null) //error handling if no player object
        {
            Debug.LogError("CharacterController component is missing from the VR Player.");
        }
    }

    void Update()
    {
        if (!movementEnabled) return; // Stop movement if disabled

        // Toggle movement when the screen is tapped
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            isMoving = !isMoving; // Stop walking if already walking
        }

        // Walk if movement is enabled
        if (isMoving)
        {
            Vector3 forward = Camera.main.transform.forward; // Move based on camera direction
            forward.y = 0; // Prevent movement from tilting up/down

            characterController.SimpleMove(forward * moveSpeed); // Use character controller object to handle movement
        }
    }
}
