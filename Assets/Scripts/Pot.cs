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
        if(isPlayerNear == true && Keyboard.current.eKey.wasPressedThisFrame && GameManager.Instance.herbs.Count >= 2)
        {
            GetPotion();
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

    public void GetPotion()
    {
        GameManager.Instance.herbs.RemoveRange(0, 2);
        GameManager.Instance.ClearInventory();
    }
}
