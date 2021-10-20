using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPannels : MonoBehaviour
{
    // Selects the parent group for the canvas you want to fade
    CanvasGroup canvas;

    public void OpenCanvas()
    {
        // Gets the CanvasGroup component needed to modify the alpha from the parent
        canvas = GetComponent<CanvasGroup>();
        // If the canvas is active, starts the coroutine and it fades in, depending on the desired time
        // Use the function OpenCanvas() to call the action
        if (this.gameObject.activeSelf == true)
        {
        StartCoroutine(FadeIn());
        }

        IEnumerator FadeIn()
        {
            // Check if the default alpha is enabled
            while ( canvas.alpha < 1f )
            {
                // Loops through different values until the alpha becomes 1
                // 1.5f is the given time between each time the loop refreshes the alpha
                canvas.alpha += Time.deltaTime / 1.5f;
                // Exit the while loop if anything goes wrong
                yield return null;
            }
        }
    }

    // Inverse loop to fade out any canvas
    // Must call the CloseCanvas() to fade out from any other script
    public void CloseCanvas()
    {
        canvas = GetComponent<CanvasGroup>();
        StartCoroutine(FadeAway());
        IEnumerator FadeAway()
        {
            while (canvas.alpha > 0.00f )
            {
                canvas.alpha -= Time.deltaTime / 1.5f;
                yield return null;
            }
        }
    }

}
