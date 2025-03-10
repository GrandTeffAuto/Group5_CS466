// This script is responsible for handling UI functions
// Gaze function not implemented due to time constraints
// Enables/disables UI's based on world events and player interaction
// It also re-enables player movement when a tutorial is completed - Alex

// Imports
using UnityEngine;
using UnityEngine.UI;

public class TutorialUIManager : MonoBehaviour
{
    // Variables
    public GameObject tutorialUI; // Assign the UI panel
    public VRPlayerMovement playerMovement; // Reference to player movement script
    public GameObject bridgeToEnable; // Assign the bridge for this tutorial
    public GameObject finalUI; // Assign FinalCanvas for the final screen

    public GameObject[] slides; // Assign Slide1, Slide2, Slide3 inside the Canvas
    private int currentSlideIndex = 0;

    public Button nextButton;
    public Button prevButton;
    public Button closeButton;

    void Start()
    {
        nextButton.onClick.AddListener(ShowNextSlide);
        prevButton.onClick.AddListener(ShowPreviousSlide);
        closeButton.onClick.AddListener(CloseTutorial);

        UpdateSlide(); // Ensure only the first slide is visible at start
    }

    // Next button functionality
    void ShowNextSlide()
    {
        if (currentSlideIndex < slides.Length - 1)
        {
            slides[currentSlideIndex].SetActive(false); // Hide current slide
            currentSlideIndex++;
            slides[currentSlideIndex].SetActive(true); // Show next slide
        }
        else
        {
            CloseTutorial(); // Close tutorial if no more slides
        }
        UpdateSlide(); // Update button states
    }

    // Previous button functionality
    void ShowPreviousSlide()
    {
        if (currentSlideIndex > 0)
        {
            slides[currentSlideIndex].SetActive(false); // Hide current slide
            currentSlideIndex--;
            slides[currentSlideIndex].SetActive(true); // Show previous slide
        }
        UpdateSlide(); // Update button states
    }

    // Close button functionality
    void CloseTutorial()
    {
        tutorialUI.SetActive(false);
        if (playerMovement != null)
        {
            playerMovement.movementEnabled = true; // Allow movement
        }
        if (bridgeToEnable != null)
        {
            bridgeToEnable.SetActive(true); // Show bridge when tutorial is completed
        }

        // If this is the last tutorial section, show Final UI!
        if (finalUI != null)
        {
            finalUI.SetActive(true);
        }
    }

    // Function to manage slide visibility and button states
    void UpdateSlide()
    {
        // Ensure only the active slide is visible
        for (int i = 0; i < slides.Length; i++)
        {
            slides[i].SetActive(i == currentSlideIndex);
        }

        // Disable Previous button on the first slide
        prevButton.interactable = currentSlideIndex > 0;

        // Disable Next button on the last slide
        nextButton.interactable = currentSlideIndex < slides.Length - 1;
    }
}
