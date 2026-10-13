using UnityEngine;

public class LevelEnd : MonoBehaviour
{

    public GameObject VictoryScreen;
    public GameObject pauseIcon;
   
    public void ShowVictoryScreen()
    {
        pauseIcon.SetActive(false);
        VictoryScreen.SetActive(true);
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Level Complete!");
            ShowVictoryScreen();
        }
        
    }
}