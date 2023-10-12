using UnityEngine;
using UnityEngine.InputSystem;
public class MovePj : MonoBehaviour
{
    [SerializeField]private PjInputs Inputs;
    [SerializeField]private CharacterController Charactercontroller;
    [SerializeField]private float angle;
    [SerializeField] private float camera_sensitive;
    private void OnEnable()
    {
        Inputs = new PjInputs();
        Inputs.Enable();
        Inputs.MoveMap.Interact.performed += Interact_performed;
    }
    private void OnDisable()
    {
        Inputs.MoveMap.Interact.performed -= Interact_performed;
        Inputs.Disable();
        Inputs = null;
    }
    private void Interact_performed(InputAction.CallbackContext obj)
    {
        Debug.Log("Mouse");
    }
    private void Awake()
    {
        Charactercontroller = this.GetComponent<CharacterController>();
        camera_sensitive = 0.5f;
    }
    private void MoveAction()
    {
        //PJ
        float RoatePjY = Inputs.MoveMap.RotatePjY.ReadValue<float>();
        Vector2 WalkPj = Inputs.MoveMap.MovePj.ReadValue<Vector2>();
        Vector3 NewPos = new Vector3(WalkPj.x, 0.0f, WalkPj.y);
        NewPos = transform.TransformDirection(NewPos);
        Charactercontroller.Move(NewPos * Time.deltaTime);
        this.transform.Rotate(0.0f, RoatePjY * camera_sensitive, 0.0f);
        //Camera
        float RotateCamera = Inputs.MoveMap.RotateCameraY.ReadValue<float>();
        angle += RotateCamera;
        angle = Mathf.Clamp(angle, -40.0f, 40.0f);
        Camera.main.transform.localEulerAngles = new Vector3(angle * camera_sensitive, 0.0f, 0.0f);
    }
    private void Update()
    {
        MoveAction();
    }
}
