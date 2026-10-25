using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Customer : MonoBehaviour
{
    [SerializeField] private GameObject[] customer;
    [SerializeField] private GameObject[] orderBubble;

    private int currentBubbleIndex;
    private int randomIndex;
    private string wantedPotion;
   
    private float timeSpawn = 3f;

    private bool isPlayerNear = false;
     
    
    void Start()
    {
        SpawnNextCustomer();
    }

    private void Update()
    {
       if(isPlayerNear && Keyboard.current.eKey.wasPressedThisFrame)
        {
            GiveOrder();
        }
    }

    private void ActivateCustomer()
    {
        randomIndex = Random.Range(0, customer.Length);

        if(customer[randomIndex] != null)
        {
            customer[randomIndex].SetActive(true);
        }
    }

    private void ActivateOrderBubbleText()
    {
        currentBubbleIndex = Random.Range(0, orderBubble.Length);

        if (orderBubble[currentBubbleIndex] != null)
        {
            orderBubble[currentBubbleIndex].SetActive(true);

            TextMeshPro currentText = orderBubble[currentBubbleIndex].GetComponentInChildren<TextMeshPro>();

            if (currentText != null)
            {
                wantedPotion = currentText.text;
            }
        }
    }
    
    private void SpawnNextCustomer()
    {
        ActivateCustomer();
        ActivateOrderBubbleText();
    }
    
    private void GiveOrder()
    {
       if(GameManager.Instance.potions.Contains(wantedPotion))
        {
            GameManager.Instance.potions.Remove(wantedPotion);
            GameManager.Instance.ClearInventory();

            GameManager.Instance.AddGold(3);

            if (customer[randomIndex]!= null) customer[randomIndex].SetActive(false);
            if (orderBubble[currentBubbleIndex]!= null) orderBubble[currentBubbleIndex].SetActive(false);

            Invoke(nameof(SpawnNextCustomer), timeSpawn);
            
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
