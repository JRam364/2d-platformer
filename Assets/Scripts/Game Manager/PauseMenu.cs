using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
    {
        TogglePause();
    }
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        // Set time to zero if true
        Time.timeScale = 0f;

        isPaused = true;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        // Set time to 1 when false
        Time.timeScale = 1f;

        isPaused = false;
    }
    public void TogglePause()
{
    if (isPaused)
    {
        Resume();
    }
    else
    {
        Pause();
    }
}

public void ReturnToMainMenu()
{
    // Reset game speed before changing scenes
    Time.timeScale = 1f;

    // Load the main menu
    SceneManager.LoadScene("MainMenu");
}
}