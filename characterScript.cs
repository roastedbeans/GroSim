using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using UnityEngine.AI;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;
using System.Linq;
using System;

public class characterScript : MonoBehaviour
{
    public GameObject itemPrefab;
    public Transform spawnPoint;
    public GameObject ItemControl;
    public GameObject gameControl;
    Transform target;

    private bool simStart = false;
    private bool isItem = false;
    private bool isSimulating = false;
    private bool isDeciding = false;
    private float distance;

    spawnScript ss;
    TimestampManager timestampManager;
    CSVDataManager csvDataManager;
    DebugLogManager debugLogManager;
    ShoppingListManager shoppingListManager;
    SimulationController simulationController;
    AILerp aILerp;

    public pythonConnection pythonConnect;

    Path path;
    private bool isValidating = false;
    private bool isHit = false;
    private bool isForcedHit = false;
    private bool endSimulation = false;
    private bool isSorting = false;
    private bool isFirst = false;
    private float decisionTime = 0;
    Seeker seeker;
    Rigidbody2D rb;
    Vector2 move = new Vector2(0f, 0f);

    List<string> shoppingList;
    List<string> cpy_shoppingList;
    List<string> currentShoppingList;
    string str_shoppingList;
    string item;
    public int customerNumber;
    List<string> sections;
    private Coroutine countdownCoroutine;
    private Coroutine initCharCoroutine;
    List<int> sectionIndices = new List<int> { 0, 1, 2, 3 }; // Use section indices instead of names
    List<float> probabilities = new List<float> { 0.20f, 0.33f, 0.31f, 0.16f };

    // Awake is called before the first frame update
    void Awake()
    {
        ss = ItemControl.GetComponent<spawnScript>();

        pythonConnect = GetComponent<pythonConnection>();

        timestampManager = ItemControl.GetComponent<TimestampManager>();
        csvDataManager = gameControl.GetComponent<CSVDataManager>();
        debugLogManager = gameControl.GetComponent<DebugLogManager>();
        simulationController = gameControl.GetComponent<SimulationController>();
        shoppingListManager = GetComponent<ShoppingListManager>();
        aILerp = GetComponent<AILerp>();
    }

    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();
        target = itemPrefab.GetComponent<Transform>();
        cpy_shoppingList = new List<string>();
        str_shoppingList = "";

    }

    // Initialize character and shopping list
    private IEnumerator initCharacter()
    {
        int datasetIterations = 1000;
        int generatedIndex = 0;
        ItemList itemList = new ItemList();
        List<List<string>> shoppingLists = shoppingListManager.shoppingLists;

        for (customerNumber = 1; customerNumber < datasetIterations && isSimulating; customerNumber++)
        {
            isFirst = true;
            if (customerNumber != 1)
            {
                isFirst = false;
            }

            itemPrefab.SetActive(false);
            transform.position = spawnPoint.position;

            if (isValidating)
            {
                if (customerNumber == 1)
                {
                    generatedIndex = Random.Range(0, 999);  //999
                    aILerp.speed = Random.Range(0.3f, 0.5f);
                }

                currentShoppingList = shoppingLists[generatedIndex];
                Shuffle(currentShoppingList);

                if (customerNumber % 2 == 0)
                {
                    isSorting = true;
                    shoppingList = currentShoppingList.Distinct().ToList();
                    Sorting();
                    generatedIndex = Random.Range(0, 999);  //999
                    aILerp.speed = Random.Range(0.3f, 0.5f);
                }
                else
                {
                    isSorting = false;
                    shoppingList = currentShoppingList.Distinct().ToList();
                    Shuffling();
                    //cpy_shoppingList = shoppingList;

                }
            }
            else
            {
                isSorting = true;
                //generatedIndex = Random.Range(0, 999);  //999

                aILerp.speed = Random.Range(0.3f, 0.5f);
                currentShoppingList = shoppingLists[generatedIndex];
                generatedIndex++;
                Shuffle(currentShoppingList);
                shoppingList = currentShoppingList.Distinct().ToList();
                Sorting();
            }

            //remove dup shopping list


            Debug.Log("New Customer Arrived");
            Debug.Log(shoppingList.Count + " items on the shopping list.");

            Debug.Log("'ORIGINAL' SHOPPING LIST");
            Debug.Log(string.Join(", ", shoppingList));

            yield return new WaitForSeconds(1f);

            yield return StartCoroutine(waitForEnd());
            Debug.Log("New Simulation");
            shoppingList.Clear();
            CancelInvoke("updatePath");
            endSimulation = false;

            if ((customerNumber % 100 == 0) && isSimulating && !isValidating)
            {
                csvDataManager.StopRecording();
                debugLogManager.StopRecording();
                yield return new WaitForSeconds(3f);

                pythonConnect.ClusterConnection();
                if (pythonConnect.ReceiveData() == "DONE.")
                {
                    csvDataManager.deleteCSVRecordings();
                    csvDataManager.StartRecording();
                    debugLogManager.StartRecording();
                }
                else
                {
                    Debug.LogError("NO RESPONSE FROM SERVER...");
                }
            }

            if ((customerNumber % 1000 == 0) && isSimulating && isValidating)
            {
                csvDataManager.StopRecording();
                debugLogManager.StopRecording();
                yield return new WaitForSeconds(3f);

                pythonConnect.ClusterConnection();
                if (pythonConnect.ReceiveData() == "DONE.")
                {
                    csvDataManager.StartValidationRecording();
                    debugLogManager.StartRecording();
                }
                else
                {
                    Debug.LogError("NO RESPONSE FROM SERVER...");
                }
            }
        }
        if (!isSimulating)
        {
            Debug.Log("Simulation Stopped");
            csvDataManager.StopRecording();
            debugLogManager.StopRecording();
        }
        else
        {
            Debug.Log("1000 Dataset Collection Complete.");
        }
    }

    // Shuffle items on the shopping list to randomize the order
    void Shuffle<T>(List<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    void Sorting()
    {
        cpy_shoppingList = shoppingList.Select(item => item).ToList();
        str_shoppingList = string.Join(",", cpy_shoppingList);
        str_shoppingList = pythonConnect.SortConnection("start^" + str_shoppingList, true);
        cpy_shoppingList = str_shoppingList.Split(", ").ToList();
    }

    void Shuffling()
    {
        cpy_shoppingList = shoppingList.Select(item => item).ToList();
        str_shoppingList = string.Join(",", cpy_shoppingList);
        str_shoppingList = pythonConnect.SortConnection("start^" + str_shoppingList, false);
        cpy_shoppingList = str_shoppingList.Split(", ").ToList();
    }

    // Start click function to start the simulation
    public void StartClick()
    {
        isValidating = false;
        // csvDataManager.deleteCSVRecordings();
        pythonConnect.ClusterConnection();
        if (pythonConnect.ReceiveData() == "DONE.")
        {
            Debug.Log("Start simulation.");
            csvDataManager.StartRecording();
            debugLogManager.StartRecording();
            isSimulating = true;

            if (initCharCoroutine != null)
            {
                initCharCoroutine = null;
            }
            initCharCoroutine = StartCoroutine(initCharacter());
        }
        else
        {
            Debug.LogError("NO RESPONSE FROM SERVER...");
        }
    }

    // Start click function to start the simulation
    public void ValidateClick()
    {
        isValidating = true;
        pythonConnect.ClusterConnection();
        if (pythonConnect.ReceiveData() == "DONE.")
        {
            Debug.Log("Start validation simulation.");
            csvDataManager.StartValidationRecording();
            debugLogManager.StartRecording();
            isSimulating = true;

            if (initCharCoroutine != null)
            {
                initCharCoroutine = null;
            }
            initCharCoroutine = StartCoroutine(initCharacter());
        }
        else
        {
            Debug.LogError("NO RESPONSE FROM SERVER...");
        }
    }

    // Exit click function to stop the simulation
    public void exitClick()
    {
        UnityEngine.Debug.Log("Exiting simulation... Current customer is invalid...");
        isSimulating = false;
    }

    // Start the decision process on the section to go to first
    private List<string> StartShopping()
    {
        sections = new List<string> { "Section1", "Section2", "Section3", "Section4" };
        Dictionary<string, double> sectionProbabilities = new Dictionary<string, double>
        {
            { "Section1", 0.20 }, //.20
            { "Section2", 0.33 }, //.33
            { "Section3", 0.31 }, //.31
            { "Section4", 0.16 }  //.16
        };

        List<string> shuffledSections = ShuffleSections(sections, sectionProbabilities);

        return shuffledSections;
    }

    // Traces the path invoked by the updatePath function every 0.1 seconds
    public void tracePath()
    {

        CancelInvoke("updatePath");
        InvokeRepeating("updatePath", 0f, 0.1f);
        if (simulationController.isSpeedUp)
        {
            simulationController.ToggleSimulationSpeed(true);
        }
    }

    // Update path from the current position to the target position
    void updatePath()
    {
        if (endSimulation)
        {
            return;
        }

        if (seeker.IsDone())
        {
            seeker.StartPath(rb.position, target.position, OnPathComplete);
        }
    }

    // Function that creates the movement of the character
    void FixedUpdate()
    {
    }


    // Path is complete, check on error
    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
        }
    }

    // Function that determines a hit on the collider, and records the timestamp
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("instance is hit");
        if (other.tag == "item" && isDeciding == false)
        {

            if (isHit == false)
            {
                if (!simStart && isItem)
                {
                    //Timestamp Start
                    Debug.Log("acquiring...");
                    simStart = true;
                    timestampManager.StartTimestamp();
                    csvDataManager.RecordItemData(item, 0, customerNumber.ToString());
                }
                else if (simStart && isItem)
                {
                    Debug.Log("acquiring...");
                    timestampManager.RecordTimestamp();
                    csvDataManager.RecordItemData(item, timestampManager.lapTime, "Good");
                }

                if (!isItem)
                {
                    Debug.Log("Finished shopping!");
                    simStart = false;
                }

                isHit = true;

            }
        }
    }

    // Visit each section in the store
    private IEnumerator VisitSections(List<string> shuffledSections)
    {
        //----------------------------------------------------------------------------------------will optimize later----REMINDER
        // Create an instance of ItemList
        ItemList itemList = new ItemList();

        string setX = "";
        bool isStart = true;

        foreach (string section in shuffledSections)
        {
            bool foundItemInSection = false;
            isItem = true;
            for (int i = 0; i < cpy_shoppingList.Count && isSimulating;)
            {

                //Debug.Log("SORTED SHOPPING LIST");
                //Debug.Log(string.Join(",", cpy_shoppingList));
                if (!isFirst)
                {
                    isHit = false;
                }

                try
                {
                    item = cpy_shoppingList[i];
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Debug.Log("Caught exception:" + ex);
                }

                bool itemFound = itemList.CheckSectionForItem(section, item);
                if (itemFound)
                {
                    Debug.Log($"Found {item} in {section}.");

                    ss.spawnObject(section, item);

                    foundItemInSection = true;

                    yield return StartCoroutine(waitForHit());

                    cpy_shoppingList.Remove(item);

                    if (isStart)
                    {
                        isStart = false;
                    }

                    setX = item;
                    //-------------------------------------------------------------------------------SORTING COULD BE ADDED IN HERE
                    if (!isStart)
                    {
                        if (isSorting)
                        {
                            str_shoppingList = string.Join(",", cpy_shoppingList);
                            if (cpy_shoppingList.Count > 1)
                                str_shoppingList = pythonConnect.SortConnection("mid^" + setX + "/" + str_shoppingList, true);
                            else if ((cpy_shoppingList.Count == 1))
                            {
                                str_shoppingList = pythonConnect.SortConnection("end^" + str_shoppingList, true);
                                Debug.Log("end of the list");
                            }
                        }

                        else if (!isSorting)
                        {
                            str_shoppingList = string.Join(",", cpy_shoppingList);
                            if (cpy_shoppingList.Count > 1)
                                str_shoppingList = pythonConnect.SortConnection("mid^" + setX + "/" + str_shoppingList, false);
                            else if ((cpy_shoppingList.Count == 1))
                            {
                                str_shoppingList = pythonConnect.SortConnection("end^" + str_shoppingList, false);
                                Debug.Log("end of the list");
                            }
                        }
                        cpy_shoppingList.Clear();
                        cpy_shoppingList = str_shoppingList.Split(", ").ToList();
                        i = 0;
                    }
                    ss.DestroySpawnedObjects();
                    itemPrefab.SetActive(false);
                    yield return new WaitForSeconds(1f);
                    itemPrefab.SetActive(true);
                    isHit = false;
                    //-------------------------------------------------------------------------------SORTING ENDED
                }

                else if (!itemFound)
                {
                    i++;
                }
            }

            if (!foundItemInSection)
            {
                Debug.Log($"Didn't find any items in {section}. Moving to the next section.");
            }
        }
        ss.spawnObject("exit", "exit");
        isItem = false;
        Debug.Log(isItem);
        yield return StartCoroutine(waitForHit());
    }

    // Wait for character to hit/aquire the item
    private IEnumerator waitForHit()
    {
        //yield return new WaitForSeconds(2f);
        tracePath(); // Start tracing the path
        if (countdownCoroutine != null)
        {
            StopCoroutine(startCountdown());
        }

        countdownCoroutine = StartCoroutine(startCountdown());
        yield return new WaitUntil(() => isHit || isForcedHit);
        isDeciding = true;
        if (simulationController.isSpeedUp)
        {
            simulationController.ToggleSimulationSpeed(false);
        }
        isForcedHit = false;

        if (isItem)
        {
            // decisionTime = Random.Range(35.0f, 60.0f);
            decisionTime = 10;
        }
        else if (!isItem)
        {
            decisionTime = 0f;
        }
        yield return new WaitForSeconds(decisionTime);
        isDeciding = false;
    }

    // Wait for end of character shopping
    private IEnumerator waitForEnd()
    {
        List<string> shuffledSections = StartShopping();
        yield return StartCoroutine(VisitSections(shuffledSections));
    }

    // Function to force hit the item if character is stuck on the item
    public void hitClicked()
    {
        Debug.Log("hit clicked!" + item);
        timestampManager.RecordTimestamp();
        csvDataManager.RecordItemData(item, timestampManager.lapTime, "force hit!");
        isForcedHit = true;
        isHit = true;
    }

    // Function to start the countdown timer every time character goes to an item, allows us to check if character is stuck on the item and force hit it when it reaches 0
    public IEnumerator startCountdown()
    {
        float seconds = 180f; // 3 minutes
        float remainingTime = seconds;

        while (remainingTime > 0)
        {
            yield return new WaitForSeconds(1f); // Wait for 1 second
            remainingTime -= 1f;
            if (isHit)
            {
                remainingTime = seconds;
                break;
            }
        }

        if (remainingTime <= 0)
        {
            Debug.Log("Character stuck on item: " + item);
            timestampManager.RecordTimestamp();
            csvDataManager.RecordItemData(item, timestampManager.lapTime, "stuck hit!");
            isForcedHit = true;
            isHit = true;
        }
    }

    // shuffle the sections and return the shuffled list
    List<string> ShuffleSections(List<string> sections, Dictionary<string, double> probabilities)
    {
        List<string> shuffledSections = new List<string>(sections);

        // Custom shuffling using Fisher-Yates algorithm
        int n = shuffledSections.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            string value = shuffledSections[k];
            shuffledSections[k] = shuffledSections[n];
            shuffledSections[n] = value;
        }

        shuffledSections.Sort(
            (a, b) =>
            {
                double probabilityA = probabilities.ContainsKey(a) ? probabilities[a] : 0.0;
                double probabilityB = probabilities.ContainsKey(b) ? probabilities[b] : 0.0;

                return Random.value < (probabilityA - probabilityB) ? -1 : 1;
            }
        );

        return shuffledSections;
    }

}
