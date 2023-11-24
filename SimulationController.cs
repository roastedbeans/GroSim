using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SimulationController : MonoBehaviour
{
    private float speedMultiplier = 20.0f; // Speed multiplier
    public Button speedButton;
    public Button hitButton;
    public Button runButton;
    public Button cancelButton;
    public Button exitButton;
    public Button startButton;
    public Button validateButton;
    public Button clusterButton;
    public Button hideButton;
    public Button nextButton;
    public Button prevButton;
    public GameObject character;
    public GameObject itemControl;
    public Dropdown typeSelection;
    public Dropdown listSelection;
    public Text textCount;
    public Text clusterText;
    characterScript cs;
    ClusterManager clusterManager;
    public bool typeSelected = false;
    public int listSelected = 0;
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
        clusterManager = itemControl.GetComponent<ClusterManager>();

        startButton = startButton.GetComponent<Button>();
        startButton.onClick.AddListener(OnStartClick);

        validateButton = validateButton.GetComponent<Button>();
        validateButton.onClick.AddListener(cs.ValidateClick);

        clusterButton = clusterButton.GetComponent<Button>();
        clusterButton.onClick.AddListener(clusterManager.ClusterConnect);
        hideButton = hideButton.GetComponent<Button>();
        hideButton.onClick.AddListener(clusterManager.HideCluster);
        nextButton = nextButton.GetComponent<Button>();
        nextButton.onClick.AddListener(clusterManager.NextCluster);
        prevButton = prevButton.GetComponent<Button>();
        prevButton.onClick.AddListener(clusterManager.PrevCluster);

        runButton = runButton.GetComponent<Button>();
        runButton.onClick.AddListener(cs.StartClick);

        cancelButton = cancelButton.GetComponent<Button>();

        speedButton = speedButton.GetComponent<Button>();
        speedButton.onClick.AddListener(ClickedToggleSimulationSpeed);

        hitButton = hitButton.GetComponent<Button>();
        hitButton.onClick.AddListener(cs.hitClicked);

        exitButton = exitButton.GetComponent<Button>();
        exitButton.onClick.AddListener(cs.exitClick);

        typeSelection = typeSelection.GetComponent<Dropdown>();
        listSelection = listSelection.GetComponent<Dropdown>();


        speedButton.gameObject.SetActive(false);
        hitButton.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(false);


    }

    public void DisplayButtonsRun()
    {
        runButton.gameObject.SetActive(false);
        cancelButton.gameObject.SetActive(false);
        speedButton.gameObject.SetActive(true);
        hitButton.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(true);
        typeSelection.interactable = false;
        listSelection.interactable = false;
    }

    public void DisplayButtonsValidate()
    {
        startButton.gameObject.SetActive(false);
        validateButton.gameObject.SetActive(false);
        clusterButton.gameObject.SetActive(false);
        speedButton.gameObject.SetActive(true);
        hitButton.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(true);
    }

    public void DisplayButtonsCluster()
    {
        startButton.gameObject.SetActive(false);
        validateButton.gameObject.SetActive(false);
        clusterButton.gameObject.SetActive(false);
        hideButton.gameObject.SetActive(true);
        nextButton.gameObject.SetActive(true);
        prevButton.gameObject.SetActive(true);

        textCount.gameObject.SetActive(false);
        clusterText.gameObject.SetActive(true);
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

    public void OnStartClick()
    {
        typeSelection.gameObject.SetActive(true);
        listSelection.gameObject.SetActive(true);

        typeSelection.onValueChanged.AddListener(delegate
        {
            
            if(typeSelection.value == 0)
            {
                typeSelected = false;
                Debug.Log("Type: Normal");
            }
            else
            {
                typeSelected = true;
                Debug.Log("Type: Sorting");
            }
        });

        listSelection.onValueChanged.AddListener(delegate
        {
            Debug.Log("List: " + listSelection.value);
            listSelected = listSelection.value;
        });
    }
}
