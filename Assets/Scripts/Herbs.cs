using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class Herbs : MonoBehaviour
{
    private bool getHerb = false;
    
    
    void Start()
    {
        
    }

    void Update()
    {
        if(Keyboard.current.eKey.wasPressedThisFrame && getHerb == true)
        {
            GameManager.Instance.AddHerb();
            Destroy(gameObject);
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
