//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/GameFolders/Scripts/Concretes/Inputs/DefaultAction.inputactions
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

namespace Udemy1.Inputs
{
    public partial class @DefaultAction: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @DefaultAction()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultAction"",
    ""maps"": [
        {
            ""name"": ""Rocket"",
            ""id"": ""3c27e6cc-3667-40d5-9011-7e4990f93a2a"",
            ""actions"": [
                {
                    ""name"": ""ForceUp"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4fa64604-17eb-4cda-b604-4be6941ef290"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftRight"",
                    ""type"": ""PassThrough"",
                    ""id"": ""39591d9d-31cb-4e86-a845-f28e007f8e00"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e92a41e4-54e7-4658-b83b-584ff9b257ff"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForceUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""4e93333f-f999-4b0c-b29b-f4a550708772"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c3a16c65-1505-467d-b5d2-26bf6bede692"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ed7b3b35-0c16-44e2-8298-34f016e89055"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Rocket
            m_Rocket = asset.FindActionMap("Rocket", throwIfNotFound: true);
            m_Rocket_ForceUp = m_Rocket.FindAction("ForceUp", throwIfNotFound: true);
            m_Rocket_LeftRight = m_Rocket.FindAction("LeftRight", throwIfNotFound: true);
        }

        ~@DefaultAction()
        {
            UnityEngine.Debug.Assert(!m_Rocket.enabled, "This will cause a leak and performance issues, DefaultAction.Rocket.Disable() has not been called.");
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

        // Rocket
        private readonly InputActionMap m_Rocket;
        private List<IRocketActions> m_RocketActionsCallbackInterfaces = new List<IRocketActions>();
        private readonly InputAction m_Rocket_ForceUp;
        private readonly InputAction m_Rocket_LeftRight;
        public struct RocketActions
        {
            private @DefaultAction m_Wrapper;
            public RocketActions(@DefaultAction wrapper) { m_Wrapper = wrapper; }
            public InputAction @ForceUp => m_Wrapper.m_Rocket_ForceUp;
            public InputAction @LeftRight => m_Wrapper.m_Rocket_LeftRight;
            public InputActionMap Get() { return m_Wrapper.m_Rocket; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(RocketActions set) { return set.Get(); }
            public void AddCallbacks(IRocketActions instance)
            {
                if (instance == null || m_Wrapper.m_RocketActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_RocketActionsCallbackInterfaces.Add(instance);
                @ForceUp.started += instance.OnForceUp;
                @ForceUp.performed += instance.OnForceUp;
                @ForceUp.canceled += instance.OnForceUp;
                @LeftRight.started += instance.OnLeftRight;
                @LeftRight.performed += instance.OnLeftRight;
                @LeftRight.canceled += instance.OnLeftRight;
            }

            private void UnregisterCallbacks(IRocketActions instance)
            {
                @ForceUp.started -= instance.OnForceUp;
                @ForceUp.performed -= instance.OnForceUp;
                @ForceUp.canceled -= instance.OnForceUp;
                @LeftRight.started -= instance.OnLeftRight;
                @LeftRight.performed -= instance.OnLeftRight;
                @LeftRight.canceled -= instance.OnLeftRight;
            }

            public void RemoveCallbacks(IRocketActions instance)
            {
                if (m_Wrapper.m_RocketActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IRocketActions instance)
            {
                foreach (var item in m_Wrapper.m_RocketActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_RocketActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public RocketActions @Rocket => new RocketActions(this);
        public interface IRocketActions
        {
            void OnForceUp(InputAction.CallbackContext context);
            void OnLeftRight(InputAction.CallbackContext context);
        }
    }
}
