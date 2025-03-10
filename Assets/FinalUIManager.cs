//This is responsible for triggering the final UI at the end of the game
//Handles restart and exit functionalities - Alex

// Imports
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalUIManager : MonoBehaviour
{
    public GameObject finalUI; // Assign FinalCanvas in the Inspector
    public VRPlayerMovement playerMovement; // Reference to player movement script

    public Button restartButton; // Assign the Restart button
    public Button exitButton; // Assign the Exit button

    void Start()
    {
        // Ensure buttons are properly assigned
        if (restartButton != null)
        {
            restartButton.onClick.AddListener(RestartGame);
        }
        else
        {
            Debug.LogError("Restart Button is not assigned in FinalUIManager!");
        }

        if (exitButton != null)
        {
            exitButton.onClick.AddListener(ExitGame);
        }
        else
        {
            Debug.LogError("Exit Button is not assigned in FinalUIManager!");
        }
    }

    // Restart the tutorial
    public void RestartGame()
    {
        Debug.Log("Restart button pressed! Reloading scene...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload current scene
    }

    // Exit the game
    public void ExitGame()
    {
        Debug.Log("Exit button pressed! Quitting game...");
        Application.Quit();
    }
}
