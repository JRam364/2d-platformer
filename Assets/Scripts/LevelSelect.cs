using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelect : MonoBehaviour
{
    // Define Gameobjects to use
    public GameObject mainMenuPanel;
    public GameObject levelSelectPanel;

    public void OpenLevelSelect()
    {
        // Turn off main menu, turn on level selector
        mainMenuPanel.SetActive(false);
        levelSelectPanel.SetActive(true);
    }
    public void CloseLevelSelect()
    {
        // Return back to main menu
        levelSelectPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    public void LoadLevel(string sceneName)
    {
        // Load scene (level, set time to 1)
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }
}
