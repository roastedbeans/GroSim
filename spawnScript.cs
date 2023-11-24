using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Pathfinding;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class spawnScript : MonoBehaviour
{
    public GameObject destination;
    public GameObject[] itemsPrefab;
    public GameObject spawnPoint;
    public GameObject character;
    public Transform parentSpawn;
    private Vector3[] spawnLocations;
    characterScript cs;

    float[] aisleRow = new float[50];
    float[] aisleCol = new float[50];
    string[] placement = new string[50];

    void Awake()
    {
        destination.SetActive(false);
        cs = character.GetComponent<characterScript>();
    }

    public void spawnObject(string section, string item)
    {
        destination.SetActive(true);
        List<Vector3> coordinates = new List<Vector3>();
        List<string> placement = new List<string>();
       
        if (section == "Section1")
        {
            coordinates = ItemList.itemCoordinates1[item];
            placement = ItemList.itemPlacement1[item];
        }
        if (section == "Section2")
        {
            coordinates = ItemList.itemCoordinates2[item];
            placement = ItemList.itemPlacement2[item];
        }
        if (section == "Section3")
        {
            coordinates = ItemList.itemCoordinates3[item];
            placement = ItemList.itemPlacement3[item];
        }
        if (section == "Section4")
        {
            coordinates = ItemList.itemCoordinates4[item];
            placement = ItemList.itemPlacement4[item];
        }
        if (section == "exit")
        {
            coordinates = ItemList.itemCoordinatesExit[item];
            placement = ItemList.itemPlacementExit[item];
        }

        spawnLocations = new Vector3[coordinates.Count];
        Vector3 closestItemPosition = Vector3.zero;
        Vector3 closestDestination = Vector3.zero;

        if (coordinates != null)
        {
            float closestDistance = float.MaxValue; // Initialize closest distance to a high value
            Vector3 characterPosition = character.transform.localPosition;

            for (int j = 0; j < coordinates.Count; j++)
            {
                Vector3 coordinate = coordinates[j];
                spawnLocations[j] = coordinate;

                itemsPrefab[j].transform.SetParent(parentSpawn);
                itemsPrefab[j].transform.localScale = new Vector3(6, 6, 2);
                itemsPrefab[j].transform.localPosition = spawnLocations[j];

                float distance = Vector3.Distance(characterPosition, spawnLocations[j]);

                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closestItemPosition = spawnLocations[j];
                    closestDestination = GetAdjustedDestination(placement[j], closestItemPosition);
                }
            }
        }
        else
        {
            Debug.Log($"Item '{item}' not found.");
        }

        // Calculate a random value between 0 and 1
        float randomValue = UnityEngine.Random.value;

        // Check if it's within the 70% for closest destination
        bool useClosestDestination = randomValue <= 0.7f;

        // Adjust the destination based on the random value
        Vector3 finalDestination;
        if (useClosestDestination)
        {
            finalDestination = closestDestination;
        }
        else
        {
            // Choose a random index for the spawnLocations array
            int randomIndex = UnityEngine.Random.Range(0, spawnLocations.Length);
            finalDestination = GetAdjustedDestination(placement[randomIndex], spawnLocations[randomIndex]);
        }

        // Set the destination
        destination.transform.localPosition = finalDestination;
    }

    public void DestroySpawnedObjects()
    {
        foreach (GameObject item in itemsPrefab)
       {
           item.transform.localPosition = new Vector3(0f, 0f, -10f);
       }
    }

    Vector3 GetAdjustedDestination(string placement, Vector3 itemPosition)
    {
        Vector3 adjustedDestination = itemPosition;

        if (placement == "left")
        {
            adjustedDestination.x -= 1;
        }
        else if (placement == "right")
        {
            adjustedDestination.x += 1;
        }
        else if (placement == "down")
        {
            adjustedDestination.y -= 1;
        }
        else if (placement == "up")
        {
            adjustedDestination.y += 1;
        }

        return new Vector3(adjustedDestination.x, adjustedDestination.y, 2);
    }
}
