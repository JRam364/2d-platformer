using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelect : MonoBehaviour
{
    
  
    public void LoadLevel(string sceneName)
    {
        // Load scene (level, set time to 1)
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }
}
