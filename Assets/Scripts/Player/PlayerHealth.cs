using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        // Make player disappear
        spriteRenderer.enabled = false;

        // Fade to black
        yield return StartCoroutine(
            ScreenFade.FadeToBlack()
        );

        // Reload the current level
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().name
        );
    }
}