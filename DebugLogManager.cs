using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DebugLogManager : MonoBehaviour
{
    private bool isRecording = false;
    private string folderPath; // Folder path for the CSV files
    private string filePath; // Current file path for the CSV file

    private void Start()
    {
        folderPath = Path.Combine(Application.dataPath, "DebugLogRecordings"); // Create a folder for recordings
        Directory.CreateDirectory(folderPath); // Create the folder if it doesn't exist

        GenerateNewFilePath();
    }

    public void StartRecording()
    {
        isRecording = true;
        Debug.Log("Recording started.");
    }

    void OnEnable()
    {
        Application.logMessageReceived += Log;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= Log;
    }

    public void Log(string logString, string stackTrace, LogType type)
    {
        if (isRecording)
        {
            if (!File.Exists(filePath)) // Check if the current file exists
            {
                GenerateNewFilePath(); // Generate a new file path if the current file doesn't exist
            }

            if (type == LogType.Error || type == LogType.Exception)
            {
                // Log error and exception messages
                TextWriter tw = new StreamWriter(filePath, true);
                tw.WriteLine("[" + System.DateTime.Now + "] ERROR: " + logString);
                tw.Close();
            }
            else
            {
                // Log other messages
                TextWriter tw = new StreamWriter(filePath, true);
                tw.WriteLine("[" + System.DateTime.Now + "] " + logString);
                tw.Close();
            }
        }
    }


    public void StopRecording()
    {
        isRecording = false;
        Debug.Log("Recording stopped.");
    }

    private void GenerateNewFilePath()
    {
        string baseFileName = "DebugLog";
        string timestamp = System.DateTime.Now.ToString("yyyyMMddHHmmss");
        string uniqueFileName = $"{baseFileName}_{timestamp}.csv";
        filePath = Path.Combine(folderPath, uniqueFileName);
    }
}
