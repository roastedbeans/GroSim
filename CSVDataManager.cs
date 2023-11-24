using UnityEngine;
using System;
using System.IO;

public class CSVDataManager : MonoBehaviour
{
    private bool isRecording = false;
    private bool isValidating = false;

    private string folderPath; // Folder path for the CSV files
    private string validationPath;
    private string filePath; // Current file path for the CSV file

    private void Start()
    {
        folderPath = Path.Combine(Application.dataPath, "CSVRecordings"); // Create a folder for recordings
        Directory.CreateDirectory(folderPath); // Create the folder if it doesn't exist
        validationPath = Path.Combine(folderPath, "CSVValidation"); // Create a folder for recordings
        Directory.CreateDirectory(validationPath); // Create the folder if it doesn't exist

        GenerateNewFilePath();
    }

    public void StartRecording()
    {
        isRecording = true;
        isValidating = false;
        Debug.Log("Recording started.");
    }

    public void StartValidationRecording()
    {
        isRecording = true;
        isValidating = true;
        Debug.Log("Recording started.");
        // for validation graph data recording
    }

    public void RecordItemData(string itemName, float timestamp, string remarks)
    {
        if (isRecording)
        {
            if (!File.Exists(filePath)) // Check if the current file exists
            {
                GenerateNewFilePath(); // Generate a new file path if the current file doesn't exist
            }

            using (StreamWriter writer = new StreamWriter(filePath, true)) // Use 'true' to append to the existing file
            {
                writer.WriteLine(string.Format("\"{0}\",{1},\"{2}\"", itemName, timestamp, remarks));
            }
            Debug.Log("Data recorded for item '" + itemName + "': " + timestamp + ", Remarks: " + remarks);
            remarks = "";
        }
    }

    public void StopRecording()
    {
        isRecording = false;
        Debug.Log("Recording stopped.");
    }

    private void GenerateNewFilePath()
    {
        if (!isValidating) {
            string baseFileName = "ItemData";
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string uniqueFileName = $"{baseFileName}_{timestamp}.csv";
            filePath = Path.Combine(folderPath, uniqueFileName);
        }
        else
        {
            string baseFileName = "ValidationData";
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string uniqueFileName = $"{baseFileName}_{timestamp}.csv";
            filePath = Path.Combine(validationPath, uniqueFileName);
        }
    }

    public void deleteCSVRecordings()
    {
        string[] csvFiles = Directory.GetFiles(folderPath, "*.csv");

        foreach (string csvFile in csvFiles)
        {
            try
            {
                // Delete each CSV file
                File.Delete(csvFile);
                Console.WriteLine("Deleted file: " + csvFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting file: " + csvFile);
                Console.WriteLine("Error message: " + ex.Message);
            }
        }
    }
}
