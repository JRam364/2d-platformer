using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public void Die()
    {
        Debug.Log("Player died!");

        gameObject.SetActive(false);
    }
}