//This script is responsible for handling UI functions
//Gaze function for VR is handled using raycasting
//It also re-enables player movement when a tutorial is completed - Alex


//Imports
using UnityEngine;

public class TutorialUIManager : MonoBehaviour
{
    public GameObject tutorialUI; // Assign the UI panel
    public VRPlayerMovement playerMovement; // Reference to player movement script
    public GameObject bridgeToEnable; // Assign the bridge for this tutorial

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            CloseTutorialAndEnableBridge();
        }
    }

    void CloseTutorialAndEnableBridge()
    {
        tutorialUI.SetActive(false); // Hide current tutorial

        if (playerMovement != null)
        {
            playerMovement.movementEnabled = true; // Allow player to move again
        }

        if (bridgeToEnable != null)
        {
            bridgeToEnable.SetActive(true); // Make the bridge visible
            Debug.Log(bridgeToEnable.name + " has been enabled.");
        }
    }
}
