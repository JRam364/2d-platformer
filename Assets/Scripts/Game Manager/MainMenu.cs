using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject levelSelectPanel;

    public void SelectLevel()
    {
        mainMenuPanel.SetActive(false);
        levelSelectPanel.SetActive(true);
    }

    public void BackToMainMenu()
        {
            levelSelectPanel.SetActive(false);
            mainMenuPanel.SetActive(true);
        }

    public void LoadLevel(int level)
    {
        SceneManager.LoadScene(level);
    }
}