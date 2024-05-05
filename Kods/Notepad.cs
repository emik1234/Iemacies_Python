using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Notepad : MonoBehaviour
{
    public List<GameObject> openedApps = new List<GameObject>();

    public GameObject notepad;
    public GameObject files;
    public GameObject book;
    public GameObject textEditor;
    public GameObject tasks;
    public Canvas canvas;
    public Canvas quiz;
    public GameObject pauseMenu;
    public GameObject howToPlay;
    public GameObject appObject;
    public GameObject credits;
    bool paused = false;

    /// <summary>
    /// <c>Update()</c>Displays and hides pause menu
    /// </summary>
    void Update()
    {
        if(paused && Input.GetKeyDown(KeyCode.Escape))
        {
            paused = false;
            pauseMenu.SetActive(false);

        } else if(!paused && Input.GetKeyDown(KeyCode.Escape))
        {
            paused = true;
            pauseMenu.SetActive(true);
        }
    }

    /// <summary>
    /// <c>ClosePauseMenu()</c>Closes pause menu
    /// </summary>
    public void ClosePauseMenu()
    {
        paused = false;
        pauseMenu.SetActive(false);
    }

    /// <summary>
    /// <c>QuitGame()</c>Closes the game
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }

    /// <summary>
    /// <c>OpenNotepad()</c>Opens app "Piezīmju Grāmatiņa"
    /// </summary>
    public void OpenNotepad(string text = "")
    {
        GameObject newNotepad = Instantiate(notepad, Vector2.zero, Quaternion.identity);
        newNotepad.transform.SetParent(canvas.transform, false);
        newNotepad.transform.SetParent(appObject.transform, false);
        if (text != "")
        {
            newNotepad.transform.Find("InputField (TMP)").GetComponent<TMP_InputField>().text = text;
        }
        
    }

    /// <summary>
    /// <c>OpenCredits()</c>Opens app "Izmantotie Resursi"
    /// </summary>
    public void OpenCredits()
    {
        GameObject newCredit = Instantiate(credits, Vector2.zero, Quaternion.identity);
        newCredit.transform.SetParent(canvas.transform, false);
        newCredit.transform.SetParent(appObject.transform, false);
    }

    /// <summary>
    /// <c>OpenFiles()</c>Opens app "Faili"
    /// </summary>
    public void OpenFiles()
    {
        GameObject newExplorer = Instantiate(files, Vector2.zero, Quaternion.identity);
        newExplorer.transform.SetParent(canvas.transform, false);
        newExplorer.transform.SetParent(appObject.transform, false);
    }

    /// <summary>
    /// <c>OpenTextEditor()</c>Opens app "Python"
    /// </summary>
    public void OpenTextEditor(string code = "")
    {
        GameObject newTextEditor = Instantiate(textEditor, Vector2.zero, Quaternion.identity);
        newTextEditor.transform.SetParent(canvas.transform, false);
        newTextEditor.transform.SetParent(appObject.transform, false);
        
        if (code != "")
        {
            newTextEditor.gameObject.SetActive(false);
            newTextEditor.transform.Find("CodeArea").GetComponent<TMP_InputField>().text = code;
            newTextEditor.gameObject.SetActive(true);
        }

    }

    /// <summary>
    /// <c>OpenBook()</c>Opens app "Pamācība"
    /// </summary>
    public void OpenBook()
    {
        GameObject newBook = Instantiate(book, Vector2.zero, Quaternion.identity);
        newBook.transform.SetParent(canvas.transform, false);
        newBook.transform.SetParent(appObject.transform, false);
    }

    /// <summary>
    /// <c>OpenTasks()</c>Opens app "Uzdevumi"
    /// </summary>
    public void OpenTasks()
    {
        GameObject newTasks = Instantiate(tasks, Vector2.zero, Quaternion.identity);
        newTasks.transform.SetParent(canvas.transform, false);
        newTasks.transform.SetParent(appObject.transform, false);
    }

    /// <summary>
    /// <c>OpenQuiz()</c>Opens app "Izvēlies Pareizo!"
    /// </summary>
    public void OpenQuiz()
    {
        Instantiate(quiz, Vector2.zero, Quaternion.identity);
    }

    /// <summary>
    /// <c>OpenHowToPlay()</c>Opens app "Kā Spēlēt?"
    /// </summary>
    public void OpenHowToPlay()
    {
        GameObject howTo = Instantiate(howToPlay, Vector2.zero, Quaternion.identity);
        howTo.transform.SetParent(canvas.transform, false);
        howTo.transform.SetParent(appObject.transform, false);
    }
}