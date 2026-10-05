using System.Collections;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private PlayerRespawn playerRespawn;
    private SpriteRenderer spriteRenderer;

    private bool isDead = false;

    void Start()
    {
        playerRespawn = GetComponent<PlayerRespawn>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Die()
    {
        if (isDead)
            return;

        isDead = true;

        StartCoroutine(DieRoutine());
    }

    private IEnumerator DieRoutine()
    {
        // Disappear immediately
        spriteRenderer.enabled = false;

        // Wait one second
        yield return new WaitForSeconds(1f);

        // Move back to spawn point
        playerRespawn.Respawn();

        // Reappear
        spriteRenderer.enabled = true;

        // Return alive
        isDead = false;
    }
}