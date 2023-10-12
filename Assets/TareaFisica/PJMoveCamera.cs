using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PJMoveCamera : MonoBehaviour
{
    public MoveCameraController controller;
    private void OnEnable()
    {
        controller = new MoveCameraController();
        controller.Enable();
        controller.BasicLookMap.Interact.performed += Interact_performed;
    }
    private void OnDisable()
    {
        controller.BasicLookMap.Interact.performed -= Interact_performed;
        controller = null;
        controller.Disable();   
    }
    private void Interact_performed(InputAction.CallbackContext obj)
    {
        print("Hola");
    }
}
