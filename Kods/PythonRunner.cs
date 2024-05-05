﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using System;
using System.IO;
using System.Text;
using Unity.VisualScripting;

public class PythonRunner : MonoBehaviour
{
    void Start()
    {

        string inGameFilesPath = System.IO.Path.Combine(Application.streamingAssetsPath.Replace("/", "\\"), "compiler.py");
        

        ExecuteScript(inGameFilesPath);
    }

    /// <summary>
    /// <c>ExecuteScript()</c>Executes user's written python script.
    /// </summary>
    /// <param name="sciptPath">Path to the python script
    public string ExecuteScript(string scriptPath)
    {
        string pythonPath = System.IO.Path.Combine(Application.streamingAssetsPath.Replace("/", "\\"), "python-3.11.6.amd64", "python.exe");
        ProcessStartInfo start = new ProcessStartInfo();
        start.FileName = pythonPath;
        start.Arguments = scriptPath;
        start.UseShellExecute = false;
        start.RedirectStandardOutput = true;
        start.CreateNoWindow = true;
        using (Process process = new Process())
        {
            process.StartInfo = start;
            process.Start();
            process.WaitForExit();
            string result = process.StandardOutput.ReadToEnd();
            return result;
        }
    }
}

/// <summary>
/// <c>StringWriterStream</c>defines a custom stream that writes data to a StringWriter, supporting only writing operations while disallowing reading and seeking.
/// </summary>
public class StringWriterStream : Stream
{
    private readonly StringWriter _stringWriter;

    public StringWriterStream(StringWriter stringWriter) => _stringWriter = stringWriter;

    public override bool CanRead => false;
    public override bool CanSeek => false;
    public override bool CanWrite => true;

    public override long Length => throw new NotSupportedException();
    public override long Position
    {
        get => throw new NotSupportedException();
        set => throw new NotSupportedException();
    }

    public override void Flush() => _stringWriter.Flush();

    public override void Write(byte[] buffer, int offset, int count) =>
        _stringWriter.Write(Encoding.UTF8.GetString(buffer, offset, count));

    public override int Read(byte[] buffer, int offset, int count) => throw new NotSupportedException();
    public override long Seek(long offset, SeekOrigin origin) => throw new NotSupportedException();
    public override void SetLength(long value) => throw new NotSupportedException();
}
