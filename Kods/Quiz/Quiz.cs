using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Quiz : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public TMP_Text QuestionTxt;

    public GameObject startScreen;
    public GameObject gameScreen;
    public GameObject howToPlayScreen;
    public GameObject gameOverScreen;
    public Timer timer;
    public GameObject parent;

    public TMP_Text gameOverScore;
    public TMP_Text correctCountText;
    public int correctCount = 0;

    public RawImage[] answerBoxes = new RawImage[3];

    public Color startColor;
    Color green = Color.green;
    Color red = Color.red;
    Color redLerped;
    Color greenLerped;
    float duration = 2f;
    public List<QuestionsAndAnswers> originalQnA = new List<QuestionsAndAnswers>();

    int correctAnsIndex;

    public Button[] buttons = new Button[3];

    void Start()
    {
        originalQnA = new List<QuestionsAndAnswers>(QnA);
    }

    /// <summary>
    /// <c>GameOver()</c>Displays results screen
    /// </summary>
    public void GameOver()
    {
        gameScreen.SetActive(false);
        gameOverScreen.SetActive(true);

        if(correctCount > 20) {
            correctCount = 20;
        }

        correctCountText.text = correctCount.ToString() + "/" + originalQnA.Count.ToString();
    }

    /// <summary>
    /// <c>Correct()</c> Adds points to score and performs an animation if the answer is correct
    /// </summary>
    public IEnumerator Correct()
    {
        foreach (Button button in buttons)
        {
            button.interactable = false;
        }

        correctCount++;
        timer.Score();
        QnA.RemoveAt(currentQuestion);

        StartCoroutine(ChangeBoxColors());
        yield return new WaitForSeconds(2);
        GenerateQuestion();
    }

    /// <summary>
    /// <c>Wrong()</c>Performs an animation if the answer is wrong
    /// </summary>
    public IEnumerator Wrong()
    {
        foreach (Button button in buttons)
        {
            button.interactable = false;
        }

        QnA.RemoveAt(currentQuestion);

        StartCoroutine(ChangeBoxColors());
        yield return new WaitForSeconds(2);
        GenerateQuestion();
    }

    /// <summary>
    /// <c>DisplayAnswers()</c> Displays answer options for a question
    /// </summary>
    void DisplayAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Answer>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TMP_Text>().text = QnA[currentQuestion].answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                correctAnsIndex = QnA[currentQuestion].CorrectAnswer;
                options[i].GetComponent<Answer>().isCorrect = true;
            }
        }
    }

    /// <summary>
    /// <c>GenerateQuestion()</c>Manages questions and displays them
    /// </summary>
    void GenerateQuestion()
    {
        if(QnA.Count > 0)
        {
            foreach(Button button in buttons)
            {
                button.interactable = true;
            }

            foreach (RawImage rawImage in answerBoxes)
            {
                rawImage.color = startColor;
            }

            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxt.text = QnA[currentQuestion].question;
            DisplayAnswers();
        }
        else
        {
            gameOverScore.text = "Punktu skaits: " + timer.totalScore.ToString();
            GameOver();
        }
    }

    /// <summary>
    /// <c>StartGame()</c>Starts the quiz game
    /// </summary>
    public void StartGame()
    {
        startScreen.SetActive(false);
        gameScreen.SetActive(true);
        timer.startingGame = true;
        GenerateQuestion();
    }

    /// <summary>
    /// <c>HowToPlay()</c>Displays "Kā Spēlēt?" information
    /// </summary>
    public void HowToPlay()
    {
        startScreen.SetActive(false);
        howToPlayScreen.SetActive(true);
    }

    /// <summary>
    /// <c>BackToStart()</c>Resets quiz data and displays start screen
    /// </summary>
    public void BackToStart()
    {   
        timer.totalScore = 0;
        timer.Score();
        correctCount = 0;
        QnA.Clear();
        QnA.AddRange(originalQnA);
        gameOverScreen.SetActive(false);
        howToPlayScreen.SetActive(false);
        startScreen.SetActive(true);
    }

    /// <summary>
    /// <c>Quit()</c>Closes the app "Izvēlies Pareizo!"
    /// </summary>
    public void Quit()
    {
        Destroy(parent);
    }

    /// <summary>
    /// <c>ChangeBoxColors()</c>Changes answer option colors when one of them is selected
    /// Correct answer changes to green and incorrect answers change to red
    /// </summary>
    IEnumerator ChangeBoxColors()
    {
        float elapsedTime = 0f;
        int i = 0;
        while (elapsedTime < duration)
        {
            i = 0;
            float t = elapsedTime / duration;
            Color redLerped = Color.Lerp(startColor, red, t);
            Color greenLerped = Color.Lerp(startColor, green, t);

            foreach (RawImage rawImage in answerBoxes)
            {
                if(i == correctAnsIndex-1)
                {
                    rawImage.color = greenLerped;
                }
                else
                {
                    rawImage.color = redLerped;
                }
                i++;
            }

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        i = 0;
        foreach (RawImage rawImage in answerBoxes)
        {
            if (i == correctAnsIndex)
            {
                rawImage.color = greenLerped;
            }
            else
            {
                rawImage.color = redLerped;
            }
            i++;
        }
    }
}
