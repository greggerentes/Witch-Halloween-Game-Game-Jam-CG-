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

    [SerializeField] private Button dryGrassButton;
    [SerializeField] private GameObject dryGrass;

    [SerializeField] private Button blueberryButton;
    [SerializeField] private GameObject blueberry;
    
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

    public void BuyGrass()
    {
        if(grass != null && !grass.activeSelf && GameManager.Instance.gold >= 1)
        {
            GameManager.Instance.RemoveGold(1);
            grass.SetActive(true);
        }
    }

    public void BuyDryGrass()
    {
        if(dryGrass != null && !dryGrass.activeSelf && GameManager.Instance.gold >= 1)
        {
            GameManager.Instance.RemoveGold(1);
            dryGrass.SetActive(true);
        }
    }

     public void BuyBlueberry()
    {
        if(blueberry != null && !blueberry.activeSelf && GameManager.Instance.gold >= 1)
        {
            GameManager.Instance.RemoveGold(1);
            blueberry.SetActive(true);
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
