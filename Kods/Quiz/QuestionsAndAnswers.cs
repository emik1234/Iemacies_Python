using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// <c>QuestionsAndAnswers</c>Creates new questions in quiz
/// </summary>
[System.Serializable]
public class QuestionsAndAnswers
{
    [TextArea(3, 3)]
    public string question;
    public string[] answers;
    public int CorrectAnswer;
}
