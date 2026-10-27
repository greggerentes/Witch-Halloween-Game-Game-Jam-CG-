using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class RecipeShopTable : MonoBehaviour
{
    [SerializeField] private GameObject recipePaper;
    [SerializeField] private GameObject herbsShopPaper;
    
    [SerializeField] private Button grassButton;
    [SerializeField] private GameObject grass;
    
    private bool isPlayerNear = false;
    
    void Start()
    {
        
    }

    private void Update()
    {
        if(isPlayerNear && Keyboard.current.eKey.wasPressedThisFrame)
        {
            Recipe();
            Shop();
        }

    }
    
    private void Recipe()
    {
        if (recipePaper == null) return;

        bool isCurrentlyOpen = recipePaper.activeSelf;
        recipePaper.SetActive(!isCurrentlyOpen);
    }

    private void Shop()
    {
        if (herbsShopPaper == null) return;

        bool isCurrentlyOpen = herbsShopPaper.activeSelf;
        herbsShopPaper.SetActive(!isCurrentlyOpen);
    }

    public void Buy()
    {
        TextMeshProUGUI buttonText = grassButton.GetComponentInChildren<TextMeshProUGUI>();
        
        if(buttonText.text == "Grass")
        {
            if(GameManager.Instance.gold >= 1)
            {
                GameManager.Instance.RemoveGold(1);
                grass.SetActive(true);
            }
        }
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
        
        if(herbsShopPaper != null)
        {
            herbsShopPaper.SetActive(false);
        }
    }
}
