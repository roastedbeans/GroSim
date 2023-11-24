using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;
//using System.Diagnostics;
using System.Linq;
using System.Text;


public class ClusterManager : MonoBehaviour
{
    public GameObject itemsPrefab;
    public GameObject itemsLegend;
    private GameObject[] instantiatedObjects;
    private GameObject[] instantiatedLegends;
    public Transform parentSpawn;
    public Text debugText;
    public Button Clusterbutton;
    public Button PrevButton;
    public Button NextButton;
    public Button HideButton;
    int maxCluster = 0;
    int cluster = 0;

    public pythonConnection pythonConnect;

    public string filePath;  // The path to file
    public string folderPath;  // The path to fodler
    public string folderName = "clusteredCSV";  // name of folder

    public string exePath;

    // Define a class to represent your data structure
    public class CSVData
    {
        public string item;
        public int cluster;
    }

    public List<CSVData> ReadCSVFile(string fileName)
    {
        List<CSVData> dataList = new List<CSVData>();

        string filePath = Path.Combine(folderPath, fileName);

        try
        {
            // Read the actual CSV content
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++) // Start from index 1 to skip the header
            {
                string line = lines[i];
                string[] values = line.Split(',');

                if (values.Length >= 2)
                {
                    CSVData data = new CSVData();
                    data.item = values[0];

                    if (int.TryParse(values[1], out int cluster))
                    {
                        data.cluster = cluster;
                        dataList.Add(data);
                    }
                    else
                    {
                        Debug.LogError("Invalid cluster number format in CSV at line " + (i + 1));
                    }
                }
                else
                {
                    Debug.LogError("Invalid CSV line format at line " + (i + 1));
                }
            }
        }
        catch (FileNotFoundException)
        {
            Debug.LogError("CSV file not found: " + fileName);
        }


        return dataList;
    }

    // Start is called before the first frame update
    void Start()
    {
        folderPath = Path.Join(Application.dataPath, "/clusteredCSV/"); // Create a folder for recordings
        Directory.CreateDirectory(folderPath); // Create the folder if it doesn't exist

        pythonConnect = GetComponent<pythonConnection>();

        Clusterbutton = Clusterbutton.GetComponent<Button>();
        Clusterbutton.onClick.AddListener(ClusterConnect);
        PrevButton = PrevButton.GetComponent<Button>();
        PrevButton.onClick.AddListener(PrevCluster);
        NextButton = NextButton.GetComponent<Button>();
        NextButton.onClick.AddListener(NextCluster);
        HideButton = HideButton.GetComponent<Button>();
        HideButton.onClick.AddListener(HideCluster);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClusterConnect()
    {

        pythonConnect.ClusterConnection();
        ClusterDone();

    }

    public void ClusterDone()
    {
        if (pythonConnect.ReceiveData() == "DONE.")
        {
            SpawnObjects();
        }
        else
        {
            Debug.LogError("NO RESPONSE FROM SERVER...");
        }
    }

    public void NextCluster()
    {
        if (cluster < maxCluster)
        {
            cluster++;
            DestroyObjects();
            SpawnObjects();
        }
        else
        {
            cluster = 0;
            DestroyObjects();
            SpawnObjects();
        }
    }

    public void PrevCluster()
    {
        if (cluster > 0)
        {
            cluster--;
            DestroyObjects();
            SpawnObjects();
        }
        else
        {
            cluster = maxCluster;
            DestroyObjects();
            SpawnObjects();
        }
    }

    public void HideCluster()
    {
        cluster = 0;
        maxCluster = 0;
        DestroyObjects();
    }

    public void DestroyObjects()
    {
        foreach (GameObject obj in instantiatedObjects)
        {
            Destroy(obj);
        }
        foreach (GameObject obj in instantiatedLegends)
        {
            Destroy(obj);
        }
    }

    public void SpawnObjects()
    {

        string fileName = System.IO.Path.Combine(folderPath, "clusters.csv");

        //string fileName = "clusters.csv"; // Remove the file extension
        List<CSVData> dataList = ReadCSVFile(fileName);


        instantiatedObjects = new GameObject[200]; // Initialize the array.
        instantiatedLegends = new GameObject[200];
        int i = 0;
        int legendLocation = 0;
        int legendInstance = 0;

        foreach (var item in dataList)
        {
            maxCluster = Mathf.Max(maxCluster, item.cluster);

            if (item.cluster == cluster) // Assuming 'cluster' is defined somewhere
            {
                // Assuming 'item.item' is the name of the item
                List<Vector3> allCoords = new List<Vector3>();

                if (ItemList.itemCoordinates1.TryGetValue(item.item, out List<Vector3> coords1))
                {
                    allCoords.AddRange(coords1);
                }

                if (ItemList.itemCoordinates2.TryGetValue(item.item, out List<Vector3> coords2))
                {
                    allCoords.AddRange(coords2);
                }

                if (ItemList.itemCoordinates3.TryGetValue(item.item, out List<Vector3> coords3))
                {
                    allCoords.AddRange(coords3);
                }

                if (ItemList.itemCoordinates4.TryGetValue(item.item, out List<Vector3> coords4))
                {
                    allCoords.AddRange(coords4);
                }
                Color randomColor = new Color(Random.value, Random.value, Random.value);

                GameObject instanceLegend = Instantiate(itemsLegend);
                TextMeshPro textLabel = instanceLegend.GetComponentInChildren<TextMeshPro>();
                SpriteRenderer legendColor = instanceLegend.GetComponentInChildren<SpriteRenderer>();

                if (legendColor != null)
                {
                    legendColor.color = randomColor;
                }
                if (textLabel != null)
                {
                    // Modify the text content
                    textLabel.text = item.item;
                }
               

                instanceLegend.transform.SetParent(parentSpawn);
                instanceLegend.transform.localScale = new Vector3(6, 6, 2);
                instanceLegend.transform.localPosition = new Vector3(77, 40 - (legendLocation), 2);

                instantiatedLegends[legendInstance] = instanceLegend;

                legendLocation += 3;
                legendInstance += 1;

                // Create objects for all coordinates
                foreach (var coord in allCoords)
                {
                    GameObject instance = Instantiate(itemsPrefab);
                    SpriteRenderer itemColor = instance.GetComponentInChildren<SpriteRenderer>();
                    instance.transform.SetParent(parentSpawn);
                    instance.transform.localScale = new Vector3(6, 6, 2);
                    instance.transform.localPosition = coord;

                    if(itemColor != null)
                    {
                        itemColor.color = randomColor;
                    }

                    instantiatedObjects[i] = instance;
                    //Debug.Log(coord);
                    //Debug.Log(item.item);
                    i++;
                }
            }
        }

        debugText.text = "Cluster: " + cluster.ToString();
        
        
    }

}
