using System.ComponentModel;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pot : MonoBehaviour
{
    private bool isPlayerNear = false;
    
    void Start()
    {
        
    }

    private void Update()
    {
        if(Keyboard.current.eKey.wasPressedThisFrame && GameManager.Instance.inventory.Count > 0)
        {
            Brew();
        }
    }

    private void Brew()
    {
        GameManager.Instance.ClearInventory();
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
