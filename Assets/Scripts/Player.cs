using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 5f;
    
    private Rigidbody2D playerRigidbody2D;
    private Vector2 movement;

    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;
        
        if(Keyboard.current.upArrowKey.isPressed)
        {
            moveY = 5f;
        }
        if(Keyboard.current.downArrowKey.isPressed)
        {
            moveY = -5f;
        }
        if(Keyboard.current.leftArrowKey.isPressed)
        {
            moveX = -5f;
        }
        if(Keyboard.current.rightArrowKey.isPressed)
        {
            moveX = 5f;
        }
        
        movement = new Vector2(moveX, moveY).normalized;

        playerRigidbody2D.linearVelocity = playerSpeed * movement;
    }
}
