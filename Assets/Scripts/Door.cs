using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject doorOpen;
    [SerializeField] private GameObject doorClosed;

    private bool isPlayerNear = false;
    
    void Start()
    {
        CloseDoor();
    }

    private void Update()
    {
        
    }

    private void OpenDoor()
    {
        if(doorOpen != null) doorOpen.SetActive(true);
        if(doorClosed != null) doorClosed.SetActive(false);
    }

    private void CloseDoor()
    {
        if(doorOpen != null) doorOpen.SetActive(false);
        if(doorClosed != null) doorClosed.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        OpenDoor();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        CloseDoor();
    }
}
