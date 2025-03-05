//Script responsible for triggering learning areas.
//Should disable movement while interacting with UI's
//Should need to be placed in each of the 3 learning zones - Alex

using UnityEngine;

public class LearningPlatformTrigger : MonoBehaviour
{
    public GameObject tutorialUI; // Assign the corresponding tutorial UI in the Inspector
    private VRPlayerMovement playerMovement; // Reference to player movement script

    void Start()
    {
        // Find the player movement script
        playerMovement = FindObjectOfType<VRPlayerMovement>(); //I know this is obsolete but using it for sake of time
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Ensure Player has the "Player" tag
        {
            // Disable player movement but allow looking around
            if (playerMovement != null)
            {
                playerMovement.movementEnabled = false;
            }

            // Show tutorial UI
            if (tutorialUI != null)
            {
                tutorialUI.SetActive(true);
            }
            else if (tutorialUI = null)
            {
                Debug.Log("No UI object has been set for this area!");
            }

            Debug.Log("Entered Learning Area: " + gameObject.name);
        }
    }
}
