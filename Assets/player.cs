using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class player : MonoBehaviour
{
    public float speed = 10f;
    public float gravity = -20f;
    public float jumpHeight = 3f;

    private CharacterController controller;
    private float velocityY;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector2 input = Vector2.zero;

        if (Keyboard.current.wKey.isPressed) input.y += 1;
        if (Keyboard.current.sKey.isPressed) input.y -= 1;
        if (Keyboard.current.aKey.isPressed) input.x -= 1;
        if (Keyboard.current.dKey.isPressed) input.x += 1;

        Vector3 move = new Vector3(input.x, 0, input.y);

        move *= speed;

        if (controller.isGrounded && velocityY < 0)
        {
            velocityY = -2f;
        }

        // 스페이스 점프
        if (Keyboard.current.spaceKey.wasPressedThisFrame && controller.isGrounded)
        {
            velocityY = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocityY += gravity * Time.deltaTime;

        move.y = velocityY;

        controller.Move(move * Time.deltaTime);
    }
}