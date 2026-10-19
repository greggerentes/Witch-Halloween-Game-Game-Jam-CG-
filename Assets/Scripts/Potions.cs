using UnityEngine;
using UnityEngine.InputSystem;


public class Potions : MonoBehaviour
{
    [SerializeField] private string potionName = "";

        private bool getPotion = false;
    
    void Start()
    {
        
    }

    private void Update()
    {
        if(Keyboard.current.eKey.wasPressedThisFrame && getPotion == true)
        {
            GameManager.Instance.AddPotion(potionName);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        getPotion = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        getPotion = false;
    }
}
