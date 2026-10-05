using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Vector3 respawnPoint;

    void Start()
    {
        respawnPoint = transform.position;
    }

    public void Respawn()
    {
        transform.position = respawnPoint;
    }
}