using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReloader : MonoBehaviour
{
    public void ReloadCurrentScene()
    {
        // Get the current scene using SceneManager
        Scene currentScene = SceneManager.GetActiveScene();

        // Load it again
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
