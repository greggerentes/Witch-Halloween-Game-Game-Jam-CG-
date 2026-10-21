using UnityEngine;
using UnityEngine.InputSystem;

public class RecipeBook : MonoBehaviour
{
    [SerializeField] private GameObject recipePaper;
    private bool isPlayerNear = false;
    
    void Start()
    {
        
    }

    private void Update()
    {
        if(isPlayerNear && Keyboard.current.eKey.wasPressedThisFrame)
        {
            Recipe();
        }

    }
    
    private void Recipe()
    {
        if (recipePaper == null) return;

        bool isCurrentlyOpen = recipePaper.activeSelf;
        recipePaper.SetActive(!isCurrentlyOpen);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPlayerNear = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerNear = false;
        if(recipePaper != null)
        {
            recipePaper.SetActive(false);
        }
    }
}
