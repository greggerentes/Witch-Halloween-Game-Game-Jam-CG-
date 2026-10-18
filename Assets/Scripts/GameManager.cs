using UnityEngine;
using System.Collections.Generic;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public List<string> inventory = new List<string>();

    [SerializeField] private InventoryUI inventoryUI;
    
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Awake()
    {
        Instance = this;
    }
    
    public void AddHerb(string item)
    {
        inventory.Add(item);

        if(inventoryUI != null)
        {
            inventoryUI.UpdateInventoryUI();
        }
    }
}
