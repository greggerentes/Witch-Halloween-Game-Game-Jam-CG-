using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementAnimation : MonoBehaviour
{
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (anim == null || Keyboard.current == null) return;

        float x = 0f;
        float y = 0f;

        // Read direct keyboard directions
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)  x -= 1f;
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) x += 1f;
        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)    y += 1f;
        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)  y -= 1f;

        Vector2 input = new Vector2(x, y);
        bool moving = input.sqrMagnitude > 0.01f;

        if (moving)
        {
            Vector2 dir = input.normalized;
            anim.SetBool("isWalking", true);
            anim.SetFloat("inputX", dir.x);
            anim.SetFloat("inputY", dir.y);
        }
        else
        {
            anim.SetBool("isWalking", false);
            anim.SetFloat("inputX", 0f);
            anim.SetFloat("inputY", 0f);
        }
    }
}