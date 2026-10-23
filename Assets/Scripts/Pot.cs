using System.ComponentModel;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pot : MonoBehaviour
{
    [SerializeField] private GameObject driedLife;
    [SerializeField] private GameObject frostGreen;

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
        if(GameManager.Instance.herbs.Contains("Grass") && GameManager.Instance.herbs.Contains("Dry Grass"))
        {
            GameManager.Instance.herbs.Remove("Grass");
            GameManager.Instance.herbs.Remove("Dry Grass");
            GameManager.Instance.ClearInventory();

            if (driedLife == null) return;

            bool ShowPotion = driedLife.activeSelf;
            driedLife.SetActive(!ShowPotion);
        }
        else if(GameManager.Instance.herbs.Contains("Grass") && GameManager.Instance.herbs.Contains("Blueberry"))
        {
            GameManager.Instance.herbs.Remove("Grass");
            GameManager.Instance.herbs.Remove("Blueberry");
            GameManager.Instance.ClearInventory();

            if (frostGreen == null) return;

            bool ShowPotion = frostGreen.activeSelf;
            frostGreen.SetActive(!ShowPotion);
        }
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
