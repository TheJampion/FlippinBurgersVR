//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/Inputs/XR Inputs.inputactions
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

public partial class @XRInputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @XRInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""XR Inputs"",
    ""maps"": [
        {
            ""name"": ""XR Left Hand"",
            ""id"": ""e1896731-aea2-4674-9070-76fbb854c63c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""9688b5fd-913b-422b-9108-3941f016b4c2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""5494a72e-2aaa-4bdc-afd2-5590680496ac"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""7506815f-961d-4a92-82c8-0abbfff9f8b9"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Velocity"",
                    ""type"": ""Value"",
                    ""id"": ""380ba36f-0459-4881-b94a-6410544305ad"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""UIPress"",
                    ""type"": ""Button"",
                    ""id"": ""40c493b3-40c9-496c-9697-89abf55a4491"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Activated"",
                    ""type"": ""Button"",
                    ""id"": ""3882a7c8-3cd4-49f1-9708-2038bbe3dc9a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""41263525-6397-428e-9d69-8c26497d8b5e"",
                    ""path"": ""<XRController>{LeftHand}/primary2DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Vector 3 Fallback"",
                    ""id"": ""d2b4b39a-c05c-49fb-9edf-adad32d80557"",
                    ""path"": ""Vector3Fallback"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""first"",
                    ""id"": ""1f6445b7-6082-48cc-b2c6-e70c41b2e7f4"",
                    ""path"": ""<XRController>{LeftHand}/pointerPosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""second"",
                    ""id"": ""5f59199b-907e-40ec-9356-f6ace063bf1f"",
                    ""path"": ""<XRController>{LeftHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""third"",
                    ""id"": ""abc4af92-f0ee-43bd-bf23-f2a7a8004004"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Quaternion Fallback"",
                    ""id"": ""289719c2-f370-4e5a-9fd0-3212f3cfff91"",
                    ""path"": ""QuaternionFallback"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""first"",
                    ""id"": ""0bcd5614-d6de-46f7-8eec-49c41d2d8bdc"",
                    ""path"": ""<XRController>{LeftHand}/pointerRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""second"",
                    ""id"": ""6e079370-0db5-40e7-a36c-5d1e20ca457c"",
                    ""path"": ""<XRController>{LeftHand}/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""third"",
                    ""id"": ""ec3f9297-f6e1-43e1-86e4-a9298f40d17a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4cf34c7d-c0da-4c18-bb93-26b2477b7ded"",
                    ""path"": ""<XRController>{LeftHand}/deviceVelocity"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Velocity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f274a31-5a73-4367-b6d3-db3d4c272cb2"",
                    ""path"": ""<XRController>{LeftHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UIPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a17ae2a4-2872-4e29-b411-9b376f5875f3"",
                    ""path"": ""<XRController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Activated"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""XR Right Hand"",
            ""id"": ""f578a61f-7307-4e78-abcd-31b94b3e7a95"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""b0504d63-f5e2-4dc8-bf91-8d48fe1cce36"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Velocity"",
                    ""type"": ""Value"",
                    ""id"": ""fd56ed1a-7c62-4547-989e-8a4816a438b0"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""854d821e-2c09-4085-98d5-bf19fb740535"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""44cee038-ce8b-4e29-93f5-ea74415035aa"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""UIPress"",
                    ""type"": ""Button"",
                    ""id"": ""4c5e474e-da29-4eec-b547-8f3ae45416e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Activated"",
                    ""type"": ""Button"",
                    ""id"": ""94921c29-430b-400e-804c-db3c922316fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""acf0e7b6-d07e-409d-b209-ae8b8a3b75a5"",
                    ""path"": ""<XRController>{RightHand}/primary2DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Vector 3 Fallback"",
                    ""id"": ""86e4e2a3-4609-43c7-a4e7-a7e0e76a3ab6"",
                    ""path"": ""Vector3Fallback"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""first"",
                    ""id"": ""dbe92c63-ff2f-4216-b679-2b20b8019d84"",
                    ""path"": ""<XRController>{RightHand}/pointerPosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""second"",
                    ""id"": ""ed32778d-d602-4be9-b935-c388b2580984"",
                    ""path"": ""<XRController>{RightHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""third"",
                    ""id"": ""24be3a0a-9920-4ffb-bd27-109647e7c005"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Quaternion Fallback"",
                    ""id"": ""8c4a8ad9-f971-4d87-86f3-8b28c12e72a5"",
                    ""path"": ""QuaternionFallback"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""first"",
                    ""id"": ""9b367ea3-2288-4257-8ed7-36e8a48483d6"",
                    ""path"": ""<XRController>{RightHand}/pointerRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""second"",
                    ""id"": ""f5aea3f5-881a-499d-b6e0-3761232aac74"",
                    ""path"": ""<XRController>{RightHand}/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""third"",
                    ""id"": ""1e0b1756-9b4b-4944-a199-a0677c13c11e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b2658cda-304e-46cb-86c2-97aef35f4319"",
                    ""path"": ""<XRController>{RightHand}/deviceVelocity"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Velocity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c0aa4e6-aa8a-4f8c-907b-939cb77e116e"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UIPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e306c3c-5ed8-4d6f-acb0-1fce9b26b08c"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Activated"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // XR Left Hand
        m_XRLeftHand = asset.FindActionMap("XR Left Hand", throwIfNotFound: true);
        m_XRLeftHand_Move = m_XRLeftHand.FindAction("Move", throwIfNotFound: true);
        m_XRLeftHand_Position = m_XRLeftHand.FindAction("Position", throwIfNotFound: true);
        m_XRLeftHand_Rotation = m_XRLeftHand.FindAction("Rotation", throwIfNotFound: true);
        m_XRLeftHand_Velocity = m_XRLeftHand.FindAction("Velocity", throwIfNotFound: true);
        m_XRLeftHand_UIPress = m_XRLeftHand.FindAction("UIPress", throwIfNotFound: true);
        m_XRLeftHand_Activated = m_XRLeftHand.FindAction("Activated", throwIfNotFound: true);
        // XR Right Hand
        m_XRRightHand = asset.FindActionMap("XR Right Hand", throwIfNotFound: true);
        m_XRRightHand_Move = m_XRRightHand.FindAction("Move", throwIfNotFound: true);
        m_XRRightHand_Velocity = m_XRRightHand.FindAction("Velocity", throwIfNotFound: true);
        m_XRRightHand_Rotation = m_XRRightHand.FindAction("Rotation", throwIfNotFound: true);
        m_XRRightHand_Position = m_XRRightHand.FindAction("Position", throwIfNotFound: true);
        m_XRRightHand_UIPress = m_XRRightHand.FindAction("UIPress", throwIfNotFound: true);
        m_XRRightHand_Activated = m_XRRightHand.FindAction("Activated", throwIfNotFound: true);
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

    // XR Left Hand
    private readonly InputActionMap m_XRLeftHand;
    private IXRLeftHandActions m_XRLeftHandActionsCallbackInterface;
    private readonly InputAction m_XRLeftHand_Move;
    private readonly InputAction m_XRLeftHand_Position;
    private readonly InputAction m_XRLeftHand_Rotation;
    private readonly InputAction m_XRLeftHand_Velocity;
    private readonly InputAction m_XRLeftHand_UIPress;
    private readonly InputAction m_XRLeftHand_Activated;
    public struct XRLeftHandActions
    {
        private @XRInputs m_Wrapper;
        public XRLeftHandActions(@XRInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_XRLeftHand_Move;
        public InputAction @Position => m_Wrapper.m_XRLeftHand_Position;
        public InputAction @Rotation => m_Wrapper.m_XRLeftHand_Rotation;
        public InputAction @Velocity => m_Wrapper.m_XRLeftHand_Velocity;
        public InputAction @UIPress => m_Wrapper.m_XRLeftHand_UIPress;
        public InputAction @Activated => m_Wrapper.m_XRLeftHand_Activated;
        public InputActionMap Get() { return m_Wrapper.m_XRLeftHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(XRLeftHandActions set) { return set.Get(); }
        public void SetCallbacks(IXRLeftHandActions instance)
        {
            if (m_Wrapper.m_XRLeftHandActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnMove;
                @Position.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnPosition;
                @Rotation.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnRotation;
                @Velocity.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnVelocity;
                @Velocity.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnVelocity;
                @Velocity.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnVelocity;
                @UIPress.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnUIPress;
                @UIPress.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnUIPress;
                @UIPress.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnUIPress;
                @Activated.started -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnActivated;
                @Activated.performed -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnActivated;
                @Activated.canceled -= m_Wrapper.m_XRLeftHandActionsCallbackInterface.OnActivated;
            }
            m_Wrapper.m_XRLeftHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Velocity.started += instance.OnVelocity;
                @Velocity.performed += instance.OnVelocity;
                @Velocity.canceled += instance.OnVelocity;
                @UIPress.started += instance.OnUIPress;
                @UIPress.performed += instance.OnUIPress;
                @UIPress.canceled += instance.OnUIPress;
                @Activated.started += instance.OnActivated;
                @Activated.performed += instance.OnActivated;
                @Activated.canceled += instance.OnActivated;
            }
        }
    }
    public XRLeftHandActions @XRLeftHand => new XRLeftHandActions(this);

    // XR Right Hand
    private readonly InputActionMap m_XRRightHand;
    private IXRRightHandActions m_XRRightHandActionsCallbackInterface;
    private readonly InputAction m_XRRightHand_Move;
    private readonly InputAction m_XRRightHand_Velocity;
    private readonly InputAction m_XRRightHand_Rotation;
    private readonly InputAction m_XRRightHand_Position;
    private readonly InputAction m_XRRightHand_UIPress;
    private readonly InputAction m_XRRightHand_Activated;
    public struct XRRightHandActions
    {
        private @XRInputs m_Wrapper;
        public XRRightHandActions(@XRInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_XRRightHand_Move;
        public InputAction @Velocity => m_Wrapper.m_XRRightHand_Velocity;
        public InputAction @Rotation => m_Wrapper.m_XRRightHand_Rotation;
        public InputAction @Position => m_Wrapper.m_XRRightHand_Position;
        public InputAction @UIPress => m_Wrapper.m_XRRightHand_UIPress;
        public InputAction @Activated => m_Wrapper.m_XRRightHand_Activated;
        public InputActionMap Get() { return m_Wrapper.m_XRRightHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(XRRightHandActions set) { return set.Get(); }
        public void SetCallbacks(IXRRightHandActions instance)
        {
            if (m_Wrapper.m_XRRightHandActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnMove;
                @Velocity.started -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnVelocity;
                @Velocity.performed -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnVelocity;
                @Velocity.canceled -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnVelocity;
                @Rotation.started -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnRotation;
                @Position.started -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnPosition;
                @UIPress.started -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnUIPress;
                @UIPress.performed -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnUIPress;
                @UIPress.canceled -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnUIPress;
                @Activated.started -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnActivated;
                @Activated.performed -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnActivated;
                @Activated.canceled -= m_Wrapper.m_XRRightHandActionsCallbackInterface.OnActivated;
            }
            m_Wrapper.m_XRRightHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Velocity.started += instance.OnVelocity;
                @Velocity.performed += instance.OnVelocity;
                @Velocity.canceled += instance.OnVelocity;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
                @UIPress.started += instance.OnUIPress;
                @UIPress.performed += instance.OnUIPress;
                @UIPress.canceled += instance.OnUIPress;
                @Activated.started += instance.OnActivated;
                @Activated.performed += instance.OnActivated;
                @Activated.canceled += instance.OnActivated;
            }
        }
    }
    public XRRightHandActions @XRRightHand => new XRRightHandActions(this);
    public interface IXRLeftHandActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnPosition(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnVelocity(InputAction.CallbackContext context);
        void OnUIPress(InputAction.CallbackContext context);
        void OnActivated(InputAction.CallbackContext context);
    }
    public interface IXRRightHandActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnVelocity(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnPosition(InputAction.CallbackContext context);
        void OnUIPress(InputAction.CallbackContext context);
        void OnActivated(InputAction.CallbackContext context);
    }
}