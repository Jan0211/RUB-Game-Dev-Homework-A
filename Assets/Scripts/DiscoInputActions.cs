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
    public struct DiscoInputMapActions
    {
        private @DiscoInputActions m_Wrapper;
        public DiscoInputMapActions(@DiscoInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @BackgroundColor => m_Wrapper.m_DiscoInputMap_BackgroundColor;
        public InputAction @SpawnNewLight => m_Wrapper.m_DiscoInputMap_SpawnNewLight;
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
            }
        }
    }
    public DiscoInputMapActions @DiscoInputMap => new DiscoInputMapActions(this);
    public interface IDiscoInputMapActions
    {
        void OnBackgroundColor(InputAction.CallbackContext context);
        void OnSpawnNewLight(InputAction.CallbackContext context);
    }
}
