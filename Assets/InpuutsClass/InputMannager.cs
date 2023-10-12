using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputMannager : MonoBehaviour
{
   private Controller controller;
    //Crear accion de slatr y suscribrse a todos los eventos
    private void OnEnable()
    {
        controller = new Controller();
        controller.Enable();
        controller.NormalMap.Jump.performed += Jump_performed;
        controller.NormalMap.Jump.canceled += Jump_canceled;
    }
    private void OnDisable()
    {
        controller.NormalMap.Jump.performed -= Jump_performed;
        controller.NormalMap.Jump.canceled -= Jump_canceled;
        controller.Disable();
        controller = null;
    }
    private void Jump_performed(InputAction.CallbackContext context)
    {
        try
        {
            Debug.Log("Jump");
        }
        catch (Exception e)
        {
            Debug.Log("Performed Error: " + e.Message);
        }
    }
    private void Jump_canceled(InputAction.CallbackContext obj)
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (Exception e)
        {
            Debug.Log("Canceled Error: " + e.Message);
        }
    }
    private void Walk()
    {
        var mov = controller.NormalMap.Move.ReadValue<Vector2>();
        this.transform.position = this.transform.position + new Vector3(mov.x, 0.0f, mov.y) * Time.deltaTime;
    }
    private void Update()
    {
        Walk();
    }
}
