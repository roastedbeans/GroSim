using UnityEngine;
using System;
using System.Collections.Generic;

public class TimestampManager : MonoBehaviour
{
    private List<float> Timestamps = new List<float>();
    private bool isTiming = false;
    private float customTime; // Custom time that resets with each StartTimestamp
    private float totalTime;
    public float lapTime;

    void FixedUpdate()
    {
        customTime += Time.deltaTime; // Increment the custom time
    }

    public void StartTimestamp()
    {
        Timestamps.Clear();
        Timestamps.Add(0f); // Initial lap time is 0
        isTiming = true;
        customTime = 0f; // Reset custom time
        Debug.Log("Timestamp started.");
    }

    public void RecordTimestamp()
    {
        if (isTiming)
        {
            lapTime = customTime;
            Timestamps.Add(lapTime);
        }
    }

    public void StopTimestamp()
    {
        if (isTiming)
        {
            totalTime = Timestamps[Timestamps.Count - 1]; // Total time is the last lap time
            isTiming = false;
        }
    }
}
