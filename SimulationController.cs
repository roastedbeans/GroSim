using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SimulationController : MonoBehaviour
{
    private float speedMultiplier = 20.0f; // Speed multiplier
    public Button speedButton;
    public Button startBtn;
    public Button hitButton;
    public Button exitBtn;
    public Button validateBtn;
    public GameObject character;
    public Text textCount;
    characterScript cs;
    public bool isSpeedUp = false;
    private float originalFixedDeltaTime;

    public void Awake()
    {
        Application.targetFrameRate = 60; // Set a high target frame rate
    }

    private void Start()
    {
        originalFixedDeltaTime = Time.fixedDeltaTime; // Store the original fixed delta time

        cs = character.GetComponent<characterScript>();
        startBtn = startBtn.GetComponent<Button>();
        startBtn.onClick.AddListener(cs.StartClick);

        validateBtn = validateBtn.GetComponent<Button>();
        validateBtn.onClick.AddListener(cs.ValidateClick);

        exitBtn = exitBtn.GetComponent<Button>();
        exitBtn.onClick.AddListener(cs.exitClick);

        speedButton = speedButton.GetComponent<Button>();
        speedButton.onClick.AddListener(ClickedToggleSimulationSpeed);

        hitButton = hitButton.GetComponent<Button>();
        hitButton.onClick.AddListener(cs.hitClicked);

        startBtn.gameObject.SetActive(true);
        speedButton.gameObject.SetActive(false);
        hitButton.gameObject.SetActive(false);
        exitBtn.gameObject.SetActive(false);

    }


    private void FixedUpdate()
    {
        textCount.text = "Customer Count: " + cs.customerNumber.ToString();
    }

    private void ClickedToggleSimulationSpeed()
    {
        isSpeedUp = !isSpeedUp;
        ToggleSimulationSpeed(isSpeedUp);
    }

    public void ToggleSimulationSpeed(bool isSpeeding)
    {
        if (!isSpeeding)
        {
            Debug.Log("Simulation speed set to normal.");
            Time.timeScale = 1.0f; // Reset time scale to normal
            Time.fixedDeltaTime = originalFixedDeltaTime; // Reset fixed delta time
        }
        else if (isSpeeding)
        {
            Debug.Log("Simulation speed set to " + speedMultiplier + "x.");
            Time.timeScale = speedMultiplier; // Set a faster simulation speed
            Time.fixedDeltaTime = originalFixedDeltaTime * speedMultiplier; // Adjust fixed delta time accordingly
        }
    }
}
