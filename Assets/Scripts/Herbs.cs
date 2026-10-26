using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class Herbs : MonoBehaviour
{
    [SerializeField] private string herbName = "";
    
    private bool getHerb = false;

    void Start()
    {
        
    }

    private void Update()
    {
        if(Keyboard.current.eKey.wasPressedThisFrame && getHerb)
        {
            GameManager.Instance.AddHerb(herbName);
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        getHerb = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        getHerb = false;
    }

    
}
