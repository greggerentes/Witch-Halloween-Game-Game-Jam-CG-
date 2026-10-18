using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI inventoryText;
    
    void Start()
    {
        UpdateInventoryUI();
    }

    void Update()
    {
        
    }

    public void UpdateInventoryUI()
    {
        if(inventoryText == null) return;

        if(GameManager.Instance.inventory.Count == 0)
        {
            inventoryText.text = "Basket:\n- Empty";
            return;
        }

        string displayText = "Basket:\n";

        foreach(string item in GameManager.Instance.inventory)
        {
            displayText += "-" + item + "\n";
        }

        inventoryText.text = displayText;
    }
}
