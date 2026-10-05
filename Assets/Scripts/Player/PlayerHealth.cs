using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private PlayerRespawn playerRespawn;

    void Start()
    {
        playerRespawn = GetComponent<PlayerRespawn>();
    }

    public void Die()
    {
        Debug.Log("Player died!");

        playerRespawn.Respawn();
    }
}