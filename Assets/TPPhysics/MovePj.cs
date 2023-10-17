using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class MovePj : MonoBehaviour
{
    [SerializeField]private MovePjTpController controller;
    [SerializeField]private float degrees_camera;
    public Action active_ray;
    private void OnEnable()
    {
        controller = new MovePjTpController();
        controller.Enable();
        controller.Move.Interact.performed += Interact_performed;
    }

   
    private void OnDisable()
    {
        controller.Move.Interact.performed -= Interact_performed;
        controller.Disable();
        controller = null;
    }
    private void Interact_performed(InputAction.CallbackContext obj)
    {
        active_ray.Invoke();
    }
    private void Awake()
    {
        degrees_camera = 0.0f;
    }
    private void RotatePj()
    {
        float rotation_pj = controller.Move.MovePj.ReadValue<float>();
        this.transform.Rotate(0.0f, rotation_pj, 0.0f);
    }
    private void RotateCamera()
    {
        float rotation_camera = controller.Move.MoveCamera.ReadValue<float>();
        degrees_camera += rotation_camera;
        degrees_camera = Mathf.Clamp(degrees_camera, -45.0f, 45.0f);
        Camera.main.transform.localEulerAngles = new Vector3 (degrees_camera, 0, 0);
    }
    private void Update()
    {
        RotateCamera();
        RotatePj();
    }

}
