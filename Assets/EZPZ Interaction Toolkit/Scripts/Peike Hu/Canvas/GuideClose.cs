using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideClose : MonoBehaviour
{
    public GameObject canvasToToggle; // Drag your Canvas GameObject here in the Inspector

    void Start()
    {
        // Pause the game immediately on start
        PauseGame();
    }

    void Update()
    {
        // Check if the spacebar was pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Toggle the active state of the Canvas
            canvasToToggle.SetActive(false);
            ResumeGame();
        }
    }

    void PauseGame()
    {
        // Set time scale to 0, freezing the game
        Time.timeScale = 0f;
        // Make sure the canvas is active to show pause menu or instructions
        canvasToToggle.SetActive(true);
    }

    void ResumeGame()
    {
        // Set time scale to 1, resuming normal game speed
        Time.timeScale = 1f;
        // Hide the canvas
        canvasToToggle.SetActive(false);
    }
}
