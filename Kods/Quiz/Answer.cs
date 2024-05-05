using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    public bool isCorrect = false;
    public Quiz quizManager;

    /// <summary>
    /// <c>CheckAnswer()</c>Checks if an answer is correct
    /// </summary>
    public void CheckAnswer()
    {
        if(this.GetComponent<Button>().interactable)
        {
            if (isCorrect)
            {
                StartCoroutine(quizManager.Correct());
            }
            else
            {
                StartCoroutine(quizManager.Wrong());
            }
        }

        this.GetComponent<Button>().interactable = false;
    }
}
