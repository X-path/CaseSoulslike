//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Input_Controls.inputactions
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

public partial class @Input_Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input_Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input_Controls"",
    ""maps"": [
        {
            ""name"": ""Game_Play"",
            ""id"": ""7ac83e36-7359-4814-8379-059dc83b88da"",
            ""actions"": [
                {
                    ""name"": ""Right_Move"",
                    ""type"": ""Button"",
                    ""id"": ""8bdc6d4c-5356-408e-9f15-f2c40b84e24a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Left_Move"",
                    ""type"": ""Button"",
                    ""id"": ""e82fae25-295b-404e-ab1b-d6401a7b6977"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""33c3a889-0eaa-4949-a1da-72e21972c924"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""661b237d-5d30-4d85-b3c3-dcb39a8af07e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Right_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5ccb8c3-7f65-4164-a781-28cdb3c212b4"",
                    ""path"": ""<HID::USB Gamepad >/stick/right"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Right_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea1c0cd4-3c0b-47b7-869b-7c7562811a9d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Left_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""040691b1-1948-4838-819a-2b70c6bfd54e"",
                    ""path"": ""<HID::USB Gamepad >/stick/left"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Left_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7be6b86a-027f-4607-9b2c-c494b9e4fec6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""812d489c-d500-421f-b0f1-8cb219c7d91d"",
                    ""path"": ""<HID::USB Gamepad >/stick/up"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": [
                {
                    ""devicePath"": ""<HID::USB Gamepad >"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Game_Play
        m_Game_Play = asset.FindActionMap("Game_Play", throwIfNotFound: true);
        m_Game_Play_Right_Move = m_Game_Play.FindAction("Right_Move", throwIfNotFound: true);
        m_Game_Play_Left_Move = m_Game_Play.FindAction("Left_Move", throwIfNotFound: true);
        m_Game_Play_Jump = m_Game_Play.FindAction("Jump", throwIfNotFound: true);
    }

    ~@Input_Controls()
    {
        UnityEngine.Debug.Assert(!m_Game_Play.enabled, "This will cause a leak and performance issues, Input_Controls.Game_Play.Disable() has not been called.");
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

    // Game_Play
    private readonly InputActionMap m_Game_Play;
    private List<IGame_PlayActions> m_Game_PlayActionsCallbackInterfaces = new List<IGame_PlayActions>();
    private readonly InputAction m_Game_Play_Right_Move;
    private readonly InputAction m_Game_Play_Left_Move;
    private readonly InputAction m_Game_Play_Jump;
    public struct Game_PlayActions
    {
        private @Input_Controls m_Wrapper;
        public Game_PlayActions(@Input_Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Right_Move => m_Wrapper.m_Game_Play_Right_Move;
        public InputAction @Left_Move => m_Wrapper.m_Game_Play_Left_Move;
        public InputAction @Jump => m_Wrapper.m_Game_Play_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Game_Play; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Game_PlayActions set) { return set.Get(); }
        public void AddCallbacks(IGame_PlayActions instance)
        {
            if (instance == null || m_Wrapper.m_Game_PlayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Game_PlayActionsCallbackInterfaces.Add(instance);
            @Right_Move.started += instance.OnRight_Move;
            @Right_Move.performed += instance.OnRight_Move;
            @Right_Move.canceled += instance.OnRight_Move;
            @Left_Move.started += instance.OnLeft_Move;
            @Left_Move.performed += instance.OnLeft_Move;
            @Left_Move.canceled += instance.OnLeft_Move;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IGame_PlayActions instance)
        {
            @Right_Move.started -= instance.OnRight_Move;
            @Right_Move.performed -= instance.OnRight_Move;
            @Right_Move.canceled -= instance.OnRight_Move;
            @Left_Move.started -= instance.OnLeft_Move;
            @Left_Move.performed -= instance.OnLeft_Move;
            @Left_Move.canceled -= instance.OnLeft_Move;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IGame_PlayActions instance)
        {
            if (m_Wrapper.m_Game_PlayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGame_PlayActions instance)
        {
            foreach (var item in m_Wrapper.m_Game_PlayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Game_PlayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Game_PlayActions @Game_Play => new Game_PlayActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    public interface IGame_PlayActions
    {
        void OnRight_Move(InputAction.CallbackContext context);
        void OnLeft_Move(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
