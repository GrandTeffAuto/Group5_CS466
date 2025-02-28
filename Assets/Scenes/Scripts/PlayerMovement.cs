using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public CharacterController controller;
    public CharacterController characterController;
    public float speed = 2.0f;
    public float gravity = -9.181f;
    public float Gravity = 9.8f;
    private float velocity = 0;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        
        Vector3 movement = transform.right * x + transform.forward * y;
        controller.Move(movement * speed * Time.deltaTime);

        if (characterController.isGrounded)
        {
            velocity = 0;
            velocity -= Gravity * Time.deltaTime;
        }
        else
        {
            characterController.Move(new Vector3(0, velocity, 0));
        }
    }
}
