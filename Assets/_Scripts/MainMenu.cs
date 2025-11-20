using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Call this to load the next level (scene)
    public void NextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        // Check if next scene exists
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
            Debug.Log("Loading Level: " + nextSceneIndex);
        }
        else
        {
            Debug.Log("No more levels.");
        }
    }

    // Call this to exit the application
    public void ExitApplication()
    {
        Application.Quit();
        Debug.Log("Exit Application.");
    }
}
