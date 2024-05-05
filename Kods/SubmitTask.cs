using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.UI;


public class SubmitTask : MonoBehaviour
{
    [SerializeField] GameObject chooseFile;
    Canvas canvas;
    [SerializeField] PythonRunner pythonRunner;
    public string ans;
    [SerializeField] SQLiteDB db;
    public ParticleSystem correctParticles;
    public TaskDisplay taskDisplay;

    void Start()
    {
        db = GameObject.Find("DBController").GetComponent<SQLiteDB>();
        taskDisplay = GameObject.Find("TaskList").GetComponent<TaskDisplay>();
        canvas = GameObject.FindWithTag("Canvas").GetComponent<Canvas>();
    }

    /// <summary>
    /// <c>Correct()</c> Performs animation when a correct task solution is submitted
    /// </summary>
    /// <param name="panel">Completed task's displayed panel to destroy</param>
    void Correct(GameObject panel)
    {
        Instantiate(correctParticles, new Vector3(0, -6.84f, 1), Quaternion.identity);

        for (int i = taskDisplay.tasks.Count - 1; i >= 0; i--)
        {
            if (ans == taskDisplay.tasks[i].answer)
            {
                db.AddDoneTask(taskDisplay.tasks[i].name + ";");
                taskDisplay.tasks.RemoveAt(i);
            }
        }

        Destroy(panel);
    }

    /// <summary>
    /// <c>Wrong()</c> Calls a function Fade() when an incorrect task solution is submitted
    /// </summary>
    void Wrong()
    {
        GameObject.FindWithTag("Fade").GetComponent<WrongAnswer>().Fade();
    }

    /// <summary>
    /// <c>OpenChooseFiles()</c> Shows all saved Python files for app "Izvēlēties Failu"
    /// </summary>
    public void OpenChooseFiles()
    {
        ans = this.GetComponentInChildren<TaskAnswer>().answer;
        GameObject panel = this.transform.parent.gameObject; 
        GameObject choose = Instantiate(chooseFile, Vector2.zero, Quaternion.identity);
        choose.transform.SetParent(canvas.transform, false);
        choose.GetComponent<TaskAnswer>().answer = ans;
        choose.GetComponent<TaskAnswer>().panel = panel;
    }
    
    /// <summary>
    /// <c>SelectFile()</c> Compares chosen file's returned data with task's correct answer.
    /// </summary>
    public void SelectFile()
    {
        string t = this.GetComponentInChildren<TextMeshProUGUI>().text;
        Transform parent = transform.parent.parent.parent;
        ans = parent.GetComponent<TaskAnswer>().answer;
        GameObject panel = parent.GetComponent<TaskAnswer>().panel;
        Destroy(parent.gameObject);
        string path = Application.persistentDataPath.Replace("/", "\\") + "\\" + "SavedFiles\\" + t;

        if (!File.Exists(path))
        {
            return;
        }

        string output = pythonRunner.ExecuteScript(path);

        ans = RemoveZeroWidthSpace(ans);
        output = RemoveZeroWidthSpace(output);

        if (output == ans)
        {
            Correct(panel);
        } else
        {
            Wrong();
        }

    }

    /// <summary>
    /// <c>RemoveZeroWidthSpace()</c> Removes '\uFEFF' zero-width space in text
    /// </summary>
    /// <param name="input">Text to remove '\uFEFF' zero-width space</param>
    string RemoveZeroWidthSpace(string input)
    {
        input = input.Trim();

        if (input.Length > 0 && input[0] == '\uFEFF')
        {
            return input.Substring(1);
        }
        return input;
    }
}
