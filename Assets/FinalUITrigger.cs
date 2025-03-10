// This script triggers the Final UI when the player steps into Learning4 - Alex

// Imports
using UnityEngine;

public class FinalUITrigger : MonoBehaviour
{
    public GameObject finalUI; // Assign FinalCanvas in the Inspector
    public VRPlayerMovement playerMovement; // Reference to player movement script

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Ensure Player has the "Player" tag
        {
            if (finalUI != null)
            {
                finalUI.SetActive(true); // Show Final UI
            }
            if (playerMovement != null)
            {
                playerMovement.movementEnabled = false; // Disable movement
            }
        }
    }
}
