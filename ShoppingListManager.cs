using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;

public class ShoppingListManager : MonoBehaviour
{
    public List<List<string>> shoppingLists = new List<List<string>>();
    public InputField fileNameInput;

    public bool LoadShoppingListsFromCSV()
    {
        string csvFileName = fileNameInput.text;
        TextAsset csvFile = Resources.Load<TextAsset>(csvFileName);

        if (csvFile != null)
        {
            string[] lines = csvFile.text.Split('\n');
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                List<string> itemList = new List<string>(items);
                shoppingLists.Add(itemList);
            }

            return true;
        }
        else
        {
            Debug.LogError("CSV file not found: " + csvFileName);
            return false;
        }
    }
}
