using System.Collections;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private PlayerRespawn playerRespawn;
    private SpriteRenderer spriteRenderer;

    public ScreenFade ScreenFade;
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
    // Player disappears
    spriteRenderer.enabled = false;

    // Fade screen to black
    yield return StartCoroutine(
        ScreenFade.FadeToBlack()
    );

    // Respawn while screen is black
    playerRespawn.Respawn();

    // Player is back
    spriteRenderer.enabled = true;

    // Fade back into the game
    yield return StartCoroutine(
        ScreenFade.FadeFromBlack()
    );

    isDead = false;
}}