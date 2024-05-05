using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;
using System.IO;
using TMPro;
using System.Text.RegularExpressions;

public class CodeOverwriter : MonoBehaviour
{
    [SerializeField] public GameObject textArea;
    [SerializeField]public PythonRunner pythonRunner;
    [SerializeField] public GameObject outputText;

    public string filePath;

    void Start()
    {
        filePath = System.IO.Path.Combine(Application.streamingAssetsPath.Replace("/", "\\"), "compiler.py");
    }

    /// <summary>
    /// <c>RemoveZeroWidthSpaces()</c>Removes "\u200b" zero-width spaces in a text
    /// </summary>
    /// <param name="code">Code to remove the "\u200b" spaces in</param>
    public string RemoveZeroWidthSpaces(string code)
    {
        return Regex.Replace(code, @"\u200b", "");
    }

    /// <summary>
    /// <c>OverwriteFile()</c>Clears the script and adds "# -*- coding: utf-8 -*-" at the line 1
    /// </summary>
    public void OverwriteFile()
    {
        if (textArea != null)
        {
            TextMeshProUGUI code = textArea.GetComponent<TextMeshProUGUI>();
            string script = code.text;
            string clearedScript = "# -*- coding: utf-8 -*-\r\n" + RemoveZeroWidthSpaces(script);

            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, clearedScript);
                string output = pythonRunner.ExecuteScript(filePath);
                outputText.GetComponent<TMP_InputField>().text = output;
            }
            else
            {
                return;
            }
        }
    }
}
