using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI herbsText;
    [SerializeField] private TextMeshProUGUI potionsText;

    private void Start()
    {
        UpdateInventoryUI();
    }

    public void UpdateInventoryUI()
    {
        UpdateHerbsText();
        UpdatePotionsText();
    }

    private void UpdateHerbsText()
    {
        if (herbsText == null) return;

        if (GameManager.Instance.herbs.Count == 0)
        {
            herbsText.text = "Herbs:\n- Empty";
            return;
        }

        string text = "Herbs:\n";
        foreach (string item in GameManager.Instance.herbs)
        {
            text += "- " + item + "\n";
        }
        herbsText.text = text;
    }

    private void UpdatePotionsText()
    {
        if (potionsText == null) return;

        if (GameManager.Instance.potions.Count == 0)
        {
            potionsText.text = "Potions:\n- Empty";
            return;
        }

        string text = "Potions:\n";
        foreach (string potion in GameManager.Instance.potions)
        {
            text += "- " + potion + "\n";
        }
        potionsText.text = text;
    }
}