using System.Collections;
using UnityEngine;

public class ScreenFade : MonoBehaviour
{
    public CanvasGroup fadeScreen;
    public float fadeSpeed = 2f;

    void Start()
    {
        fadeScreen.alpha = 1f;
        StartCoroutine(FadeFromBlack());
    }

    public IEnumerator FadeToBlack()
    {
        while (fadeScreen.alpha < 1f)
        {
            fadeScreen.alpha += fadeSpeed * Time.deltaTime;
            yield return null;
        }

        fadeScreen.alpha = 1f;
    }

    public IEnumerator FadeFromBlack()
    {
        while (fadeScreen.alpha > 0f)
        {
            fadeScreen.alpha -= fadeSpeed * Time.deltaTime;
            yield return null;
        }

        fadeScreen.alpha = 0f;
    }
}