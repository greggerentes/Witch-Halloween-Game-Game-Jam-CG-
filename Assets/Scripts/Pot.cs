using System.ComponentModel;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pot : MonoBehaviour
{
    [SerializeField] private GameObject driedLife;
    [SerializeField] private GameObject frostGreen;
    [SerializeField] private GameObject dustyBerry;

    private bool isPlayerNear = false;
    
    void Start()
    {
        
    }

    private void Update()
    {
        if(isPlayerNear == true && Keyboard.current.eKey.wasPressedThisFrame)
        {
            MakePotion();
        }
    }

    public void MakePotion()
    {
        if(GameManager.Instance.herbs.Count < 2) return;
        
        
        string herb1 = GameManager.Instance.herbs[0];
        string herb2 = GameManager.Instance.herbs[1];
        
        if(IsCombination(herb1, herb2, "Grass", "Dry Grass"))
        {
            ConsumeFirstTwo();

            if (driedLife != null) driedLife.SetActive(true);
            GameManager.Instance.ClearInventory();
        }
        else if(IsCombination(herb1, herb2, "Grass", "Blueberry"))
        {
            ConsumeFirstTwo();

            if (frostGreen != null) frostGreen.SetActive(true);
            GameManager.Instance.ClearInventory();
        }
        else if(IsCombination(herb1, herb2, "Dry Grass", "Blueberry"))
        {
            ConsumeFirstTwo();

            if (dustyBerry != null) dustyBerry.SetActive(true);
            GameManager.Instance.ClearInventory();
        }
    }

    private bool IsCombination(string h1, string h2, string requiredA, string requiredB)
    {
        return (h1 == requiredA && h2 == requiredB || (h1 == requiredB && h2 == requiredA));
    }

    private void ConsumeFirstTwo()
    {
        GameManager.Instance.herbs.RemoveRange(0, 2);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPlayerNear = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerNear = false;
    }

    
}
