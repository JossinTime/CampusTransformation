using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SimpleInventoryTMP : MonoBehaviour
{
    public static SimpleInventoryTMP instance;
    public List<string> items = new List<string>();
    public TMP_Text inventoryText; // Assign your TMP Text object here

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Multiple inventory instances!");
            Destroy(gameObject);
            return;
        }
        instance = this;

        // Initialize with empty inventory
        UpdateInventoryDisplay();
    }

    public void AddItem(string itemName)
    {
        items.Add(itemName);
        UpdateInventoryDisplay();
        Debug.Log("Added: " + itemName);
    }

    void UpdateInventoryDisplay()
    {
        if (inventoryText == null)
        {
            Debug.LogError("TMP Text not assigned!");
            return;
        }

        // Build the inventory string
        string inventoryString = "INVENTORY:\n";

        if (items.Count == 0)
        {
            inventoryString += "Empty";
        }
        else
        {
            foreach (string item in items)
            {
                inventoryString += $"• {item}\n";
            }
        }

        inventoryText.text = inventoryString;
    }
}