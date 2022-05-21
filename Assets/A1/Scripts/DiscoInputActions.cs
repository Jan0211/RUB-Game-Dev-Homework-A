//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/DiscoInputActions.inputactions
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

public partial class @DiscoInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DiscoInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DiscoInputActions"",
    ""maps"": [
        {
            ""name"": ""DiscoInputMap"",
            ""id"": ""c6680ac4-62fc-44f7-ba84-e4db5f27e594"",
            ""actions"": [
                {
                    ""name"": ""BackgroundColor"",
                    ""type"": ""Value"",
                    ""id"": ""f86d8659-c9c7-4273-b4ff-1f7619fbe09f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SpawnNewLight"",
                    ""type"": ""Button"",
                    ""id"": ""4fca640c-9b48-4fcf-9f2c-cfed93b28e43"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""db1ff2b1-ba10-4813-aaec-5fd945d4977a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""3454eece-5410-4468-b9ba-249ed21483f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Stealth"",
                    ""type"": ""Button"",
                    ""id"": ""d2091145-7306-4ea7-bb30-f98529fffad4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangeSprite"",
                    ""type"": ""Button"",
                    ""id"": ""71f6d521-2029-4d63-a607-d72dc0879c71"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dance1"",
                    ""type"": ""Button"",
                    ""id"": ""636ace61-e9c0-428b-b733-5bc08998aa7a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dance2"",
                    ""type"": ""Button"",
                    ""id"": ""4ac28748-fd9d-46a2-9492-3187bc787f70"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dance3"",
                    ""type"": ""Button"",
                    ""id"": ""d34e9a7f-3bcc-4549-b033-ef9c5e06366a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b85162d4-3ced-487f-ab40-573b68aed0c0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackgroundColor"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7720d43d-e8c7-4208-b113-087585390c50"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackgroundColor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f40d579a-f64f-4c58-bacb-05db9ad14f37"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackgroundColor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fa2b8e39-ebe6-4faf-b658-672d4fe13f34"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnNewLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""19630d2b-3ce6-42ea-ab9f-16a2a2c57f77"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""950fa694-17ba-47fb-b320-2bc1d749296d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a94ec75a-6f0b-403c-98d6-e07fa55163ca"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ac3521bf-29ec-4fbd-b6ac-9da9b92baa6c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""934eb495-3ba4-4c56-a467-1ff19e79b356"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""54bf642b-f5c4-451b-b6a0-cb09a157854d"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1773e7d0-3c0c-4b93-95e5-5a2ed8dd74da"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stealth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de6c5039-579f-489b-9796-80bf5f202852"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeSprite"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b3a4277-b809-4d9f-913a-bc5c4051776c"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dance1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73b21ec3-4181-468f-9c35-12e7637d9296"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dance2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b2de18c-7ed5-4799-ad87-37085daf984f"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dance3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // DiscoInputMap
        m_DiscoInputMap = asset.FindActionMap("DiscoInputMap", throwIfNotFound: true);
        m_DiscoInputMap_BackgroundColor = m_DiscoInputMap.FindAction("BackgroundColor", throwIfNotFound: true);
        m_DiscoInputMap_SpawnNewLight = m_DiscoInputMap.FindAction("SpawnNewLight", throwIfNotFound: true);
        m_DiscoInputMap_Move = m_DiscoInputMap.FindAction("Move", throwIfNotFound: true);
        m_DiscoInputMap_Sprint = m_DiscoInputMap.FindAction("Sprint", throwIfNotFound: true);
        m_DiscoInputMap_Stealth = m_DiscoInputMap.FindAction("Stealth", throwIfNotFound: true);
        m_DiscoInputMap_ChangeSprite = m_DiscoInputMap.FindAction("ChangeSprite", throwIfNotFound: true);
        m_DiscoInputMap_Dance1 = m_DiscoInputMap.FindAction("Dance1", throwIfNotFound: true);
        m_DiscoInputMap_Dance2 = m_DiscoInputMap.FindAction("Dance2", throwIfNotFound: true);
        m_DiscoInputMap_Dance3 = m_DiscoInputMap.FindAction("Dance3", throwIfNotFound: true);
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

    // DiscoInputMap
    private readonly InputActionMap m_DiscoInputMap;
    private IDiscoInputMapActions m_DiscoInputMapActionsCallbackInterface;
    private readonly InputAction m_DiscoInputMap_BackgroundColor;
    private readonly InputAction m_DiscoInputMap_SpawnNewLight;
    private readonly InputAction m_DiscoInputMap_Move;
    private readonly InputAction m_DiscoInputMap_Sprint;
    private readonly InputAction m_DiscoInputMap_Stealth;
    private readonly InputAction m_DiscoInputMap_ChangeSprite;
    private readonly InputAction m_DiscoInputMap_Dance1;
    private readonly InputAction m_DiscoInputMap_Dance2;
    private readonly InputAction m_DiscoInputMap_Dance3;
    public struct DiscoInputMapActions
    {
        private @DiscoInputActions m_Wrapper;
        public DiscoInputMapActions(@DiscoInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @BackgroundColor => m_Wrapper.m_DiscoInputMap_BackgroundColor;
        public InputAction @SpawnNewLight => m_Wrapper.m_DiscoInputMap_SpawnNewLight;
        public InputAction @Move => m_Wrapper.m_DiscoInputMap_Move;
        public InputAction @Sprint => m_Wrapper.m_DiscoInputMap_Sprint;
        public InputAction @Stealth => m_Wrapper.m_DiscoInputMap_Stealth;
        public InputAction @ChangeSprite => m_Wrapper.m_DiscoInputMap_ChangeSprite;
        public InputAction @Dance1 => m_Wrapper.m_DiscoInputMap_Dance1;
        public InputAction @Dance2 => m_Wrapper.m_DiscoInputMap_Dance2;
        public InputAction @Dance3 => m_Wrapper.m_DiscoInputMap_Dance3;
        public InputActionMap Get() { return m_Wrapper.m_DiscoInputMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DiscoInputMapActions set) { return set.Get(); }
        public void SetCallbacks(IDiscoInputMapActions instance)
        {
            if (m_Wrapper.m_DiscoInputMapActionsCallbackInterface != null)
            {
                @BackgroundColor.started -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnBackgroundColor;
                @BackgroundColor.performed -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnBackgroundColor;
                @BackgroundColor.canceled -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnBackgroundColor;
                @SpawnNewLight.started -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnSpawnNewLight;
                @SpawnNewLight.performed -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnSpawnNewLight;
                @SpawnNewLight.canceled -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnSpawnNewLight;
                @Move.started -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnMove;
                @Sprint.started -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnSprint;
                @Stealth.started -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnStealth;
                @Stealth.performed -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnStealth;
                @Stealth.canceled -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnStealth;
                @ChangeSprite.started -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnChangeSprite;
                @ChangeSprite.performed -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnChangeSprite;
                @ChangeSprite.canceled -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnChangeSprite;
                @Dance1.started -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnDance1;
                @Dance1.performed -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnDance1;
                @Dance1.canceled -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnDance1;
                @Dance2.started -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnDance2;
                @Dance2.performed -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnDance2;
                @Dance2.canceled -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnDance2;
                @Dance3.started -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnDance3;
                @Dance3.performed -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnDance3;
                @Dance3.canceled -= m_Wrapper.m_DiscoInputMapActionsCallbackInterface.OnDance3;
            }
            m_Wrapper.m_DiscoInputMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @BackgroundColor.started += instance.OnBackgroundColor;
                @BackgroundColor.performed += instance.OnBackgroundColor;
                @BackgroundColor.canceled += instance.OnBackgroundColor;
                @SpawnNewLight.started += instance.OnSpawnNewLight;
                @SpawnNewLight.performed += instance.OnSpawnNewLight;
                @SpawnNewLight.canceled += instance.OnSpawnNewLight;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Stealth.started += instance.OnStealth;
                @Stealth.performed += instance.OnStealth;
                @Stealth.canceled += instance.OnStealth;
                @ChangeSprite.started += instance.OnChangeSprite;
                @ChangeSprite.performed += instance.OnChangeSprite;
                @ChangeSprite.canceled += instance.OnChangeSprite;
                @Dance1.started += instance.OnDance1;
                @Dance1.performed += instance.OnDance1;
                @Dance1.canceled += instance.OnDance1;
                @Dance2.started += instance.OnDance2;
                @Dance2.performed += instance.OnDance2;
                @Dance2.canceled += instance.OnDance2;
                @Dance3.started += instance.OnDance3;
                @Dance3.performed += instance.OnDance3;
                @Dance3.canceled += instance.OnDance3;
            }
        }
    }
    public DiscoInputMapActions @DiscoInputMap => new DiscoInputMapActions(this);
    public interface IDiscoInputMapActions
    {
        void OnBackgroundColor(InputAction.CallbackContext context);
        void OnSpawnNewLight(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnStealth(InputAction.CallbackContext context);
        void OnChangeSprite(InputAction.CallbackContext context);
        void OnDance1(InputAction.CallbackContext context);
        void OnDance2(InputAction.CallbackContext context);
        void OnDance3(InputAction.CallbackContext context);
    }
}