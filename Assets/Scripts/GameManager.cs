using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public List<string> herbs = new List<string>();
    public List<string> potions = new List<string>();

    [SerializeField] private InventoryUI inventoryUI;
    


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

    public void ClearInventory()
    {

        if (inventoryUI != null)
        {
            inventoryUI.UpdateInventoryUI();
        }
    }
}