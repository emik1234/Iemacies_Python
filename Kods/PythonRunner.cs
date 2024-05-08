using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using System;
using System.IO;
using System.Text;
using Unity.VisualScripting;

public class PythonRunner : MonoBehaviour
{
    /// <summary>
    /// <c>ExecuteScript()</c>Executes user's written python script.
    /// </summary>
    /// <param name="sciptPath">Path to the python script
    public string ExecuteScript(string scriptPath)
    {
        string pythonPath = Path.Combine(Application.streamingAssetsPath.Replace("/", "\\"), "python-3.11.6.amd64", "python.exe");

        ProcessStartInfo start = new()
        {
            FileName = "\"" + pythonPath + "\"",
            Arguments = "\"" + scriptPath + "\"",
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            CreateNoWindow = true
        };

        using (Process process = new())
        {
            process.StartInfo = start;
            process.Start();
            process.WaitForExit();
    
            string result = process.StandardOutput.ReadToEnd();

            return result;
        }
        
    }
}
