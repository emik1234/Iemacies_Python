using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class WrongAnswer : MonoBehaviour
{
    public CanvasGroup canvasGroup;
   private bool _fadeIn = false;
   private bool _fadeOut = false;


    /// <summary>
    /// <c>Update()</c> Fades in and out the red animation when an incorrect task solution is submitted
    /// </summary>
    void Update() {
        if(_fadeIn) {
            if(canvasGroup.alpha < 1) {
                canvasGroup.alpha += Time.deltaTime * 0.5f;
                if(canvasGroup.alpha >= 1) {
                    _fadeIn = false;
                    _fadeOut = true;
                }
            }
        }

        if(_fadeOut) {
            if(canvasGroup.alpha >= 0) {
                canvasGroup.alpha -= Time.deltaTime * 0.5f;
                if(canvasGroup.alpha <= 0) {
                    _fadeOut = false;
                }
            }
        }

        this.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    /// <summary>
    /// <c>Fade()</c> Sets variable _fadeIn and _fadeOut values to default
    /// </summary>
    public void Fade() {
        

        _fadeIn = true;
        _fadeOut = false;
    }
}
