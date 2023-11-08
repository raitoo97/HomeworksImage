//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/TareaFisica/MoveCameraController.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @MoveCameraController: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MoveCameraController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MoveCameraController"",
    ""maps"": [
        {
            ""name"": ""BasicLookMap"",
            ""id"": ""6a282869-d7af-4ec0-bbae-f9f5d5af00a1"",
            ""actions"": [
                {
                    ""name"": ""MoveCamera"",
                    ""type"": ""Value"",
                    ""id"": ""f4d1eefc-0714-4d23-b9eb-121e93098c25"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MovePj"",
                    ""type"": ""Value"",
                    ""id"": ""e2557600-86bd-4c8e-ba41-13792aaa4ade"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""79d92e04-50e5-425f-b357-428ccf3ca65f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3ba360c2-35f1-4723-9319-88c58aae779e"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6acdedd6-69e6-40c6-a63d-fc6758c0d5e4"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovePj"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5afd7071-6d54-46d3-ae65-be16d69a4f1f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BasicLookMap
        m_BasicLookMap = asset.FindActionMap("BasicLookMap", throwIfNotFound: true);
        m_BasicLookMap_MoveCamera = m_BasicLookMap.FindAction("MoveCamera", throwIfNotFound: true);
        m_BasicLookMap_MovePj = m_BasicLookMap.FindAction("MovePj", throwIfNotFound: true);
        m_BasicLookMap_Interact = m_BasicLookMap.FindAction("Interact", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // BasicLookMap
    private readonly InputActionMap m_BasicLookMap;
    private List<IBasicLookMapActions> m_BasicLookMapActionsCallbackInterfaces = new List<IBasicLookMapActions>();
    private readonly InputAction m_BasicLookMap_MoveCamera;
    private readonly InputAction m_BasicLookMap_MovePj;
    private readonly InputAction m_BasicLookMap_Interact;
    public struct BasicLookMapActions
    {
        private @MoveCameraController m_Wrapper;
        public BasicLookMapActions(@MoveCameraController wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveCamera => m_Wrapper.m_BasicLookMap_MoveCamera;
        public InputAction @MovePj => m_Wrapper.m_BasicLookMap_MovePj;
        public InputAction @Interact => m_Wrapper.m_BasicLookMap_Interact;
        public InputActionMap Get() { return m_Wrapper.m_BasicLookMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BasicLookMapActions set) { return set.Get(); }
        public void AddCallbacks(IBasicLookMapActions instance)
        {
            if (instance == null || m_Wrapper.m_BasicLookMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_BasicLookMapActionsCallbackInterfaces.Add(instance);
            @MoveCamera.started += instance.OnMoveCamera;
            @MoveCamera.performed += instance.OnMoveCamera;
            @MoveCamera.canceled += instance.OnMoveCamera;
            @MovePj.started += instance.OnMovePj;
            @MovePj.performed += instance.OnMovePj;
            @MovePj.canceled += instance.OnMovePj;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
        }

        private void UnregisterCallbacks(IBasicLookMapActions instance)
        {
            @MoveCamera.started -= instance.OnMoveCamera;
            @MoveCamera.performed -= instance.OnMoveCamera;
            @MoveCamera.canceled -= instance.OnMoveCamera;
            @MovePj.started -= instance.OnMovePj;
            @MovePj.performed -= instance.OnMovePj;
            @MovePj.canceled -= instance.OnMovePj;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
        }

        public void RemoveCallbacks(IBasicLookMapActions instance)
        {
            if (m_Wrapper.m_BasicLookMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IBasicLookMapActions instance)
        {
            foreach (var item in m_Wrapper.m_BasicLookMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_BasicLookMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public BasicLookMapActions @BasicLookMap => new BasicLookMapActions(this);
    public interface IBasicLookMapActions
    {
        void OnMoveCamera(InputAction.CallbackContext context);
        void OnMovePj(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}