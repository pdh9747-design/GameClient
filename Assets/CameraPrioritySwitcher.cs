using UnityEngine;
using Unity.Cinemachine;
using UnityEngine.InputSystem;

public class CameraPrioritySwitcher : MonoBehaviour
{
    public CinemachineCamera backCamera;
    public CinemachineCamera frontCamera;

    void Update()
    {
        if (Keyboard.current.digit1Key.wasPressedThisFrame)
        {
            backCamera.Priority = 20;
            frontCamera.Priority = 10;
        }

        if (Keyboard.current.digit2Key.wasPressedThisFrame)
        {
            backCamera.Priority = 10;
            frontCamera.Priority = 20;
        }
    }
}