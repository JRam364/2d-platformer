using System.Collections;
using UnityEngine;

public class ScreenFade : MonoBehaviour
{
    public CanvasGroup fadeScreen;
    public float fadeSpeed = 2f;

    public IEnumerator FadeToBlack()
    {
        while (fadeScreen.alpha < 1)
        {
            fadeScreen.alpha += fadeSpeed * Time.deltaTime;
            yield return null;
        }

        fadeScreen.alpha = 1;
    }

    public IEnumerator FadeFromBlack()
    {
        while (fadeScreen.alpha > 0)
        {
            fadeScreen.alpha -= fadeSpeed * Time.deltaTime;
            yield return null;
        }

        fadeScreen.alpha = 0;
    }
}