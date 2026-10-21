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
        
        if(Keyboard.current.wKey.isPressed)
        {
            moveY = 5f;
        }
        if(Keyboard.current.sKey.isPressed)
        {
            moveY = -5f;
        }
        if(Keyboard.current.aKey.isPressed)
        {
            moveX = -5f;
        }
        if(Keyboard.current.dKey.isPressed)
        {
            moveX = 5f;
        }
        
        movement = new Vector2(moveX, moveY).normalized;

        playerRigidbody2D.linearVelocity = playerSpeed * movement;
    }
}
