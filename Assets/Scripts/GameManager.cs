using UnityEngine;
using System.Collections.Generic;
using TMPro;
using Unity.AppUI.UI;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public List<string> herbs = new List<string>();
    public List<string> potions = new List<string>();

    public int gold = 0;
    

    [SerializeField] private InventoryUI inventoryUI;
    [SerializeField] private TextMeshProUGUI goldTextUI;
    


    private void Awake()
    {
        Instance = this;
    }
    
    public void AddHerb(string item)
    {
        herbs.Add(item);

        if (inventoryUI != null)
        {
            inventoryUI.UpdateInventoryUI();
        }
    }

    public void AddPotion(string item)
    {
        potions.Add(item);

        if (inventoryUI != null)
        {
            inventoryUI.UpdateInventoryUI();
        }
    }

    public void AddGold(int amount)
    {
        gold += amount;
        string text;
        text = "Gold: " + gold;
        goldTextUI.text = text;
    }

    public void RemoveGold(int amount)
    {
        gold -= amount;
        string text;
        text = "Gold: " + gold;
        goldTextUI.text = text;
    }
    
    public void ClearInventory()
    {

        if (inventoryUI != null)
        {
            inventoryUI.UpdateInventoryUI();
        }
    }
}