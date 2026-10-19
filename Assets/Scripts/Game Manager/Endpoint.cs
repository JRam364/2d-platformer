using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{

    public GameObject VictoryScreen;
    public GameObject pauseIcon;
    // Player level defaults to 1
    [SerializeField] private int levelNumber = 1;
   
    public void ShowVictoryScreen()
    {
        pauseIcon.SetActive(false);
        VictoryScreen.SetActive(true);
        // Get the new unlocked level from PlayerPrefs
        int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);

    if (levelNumber + 1 > unlockedLevel)
    {   
        // Make current level number + 1 unlocked
        PlayerPrefs.SetInt("UnlockedLevel", levelNumber + 1);
        PlayerPrefs.Save();
    }
}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Level Complete!");
            ShowVictoryScreen();
        }
        
    }
    // Function for button to load next level
  public void NextLevel()
    {
        Time.timeScale = 1f;

        int nextLevel = levelNumber + 1;

        SceneManager.LoadScene(nextLevel.ToString());
    }
}