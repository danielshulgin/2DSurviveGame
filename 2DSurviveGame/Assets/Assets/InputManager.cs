// GENERATED AUTOMATICALLY FROM 'Assets/InputManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;
using UnityEngine.Experimental.Input.Utilities;

public class InputManager : IInputActionCollection
{
    private InputActionAsset asset;
    public InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputManager"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""e925154f-891e-4167-9c12-c373e9bf44bd"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""id"": ""c09a7f13-ba61-4a73-b5b1-e44f3cc9615c"",
                    ""expectedControlLayout"": """",
                    ""continuous"": true,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Shoot"",
                    ""id"": ""00678567-88cb-4b26-9bb6-4de8d6a28a55"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Direction"",
                    ""id"": ""5e2186d8-2ee6-4ed7-9af6-f286aa430082"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""StartShoot"",
                    ""id"": ""f363f89f-f578-42cf-8af7-45fdfb6f0458"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""EndShoot"",
                    ""id"": ""f114e12a-4ee5-45eb-b420-3d3099256629"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""arrowKeys"",
                    ""id"": ""4c346ab8-11b1-4c38-9b00-23c3a255edde"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ddda5d1a-5505-4858-b922-5860c1909710"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a191f1af-e72b-400f-ae6d-5b8d776eea60"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""left"",
                    ""id"": ""88606cb9-446c-457c-b471-dcfb4cd16ab1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bf499cd2-30db-4297-9268-7c0b6abbd480"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""b393eacf-40cb-4d9e-9dea-d100cbfbdcdb"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";PC"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""d639a126-a87f-44b3-9063-9d6457e9caf3"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";PC"",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""d4a40baa-ac21-457f-9c8e-78e809aef5f1"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": "";PC"",
                    ""action"": ""StartShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""9616a509-bbf5-46dd-b57e-5e5d8492b89d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": "";PC"",
                    ""action"": ""EndShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""basedOn"": """",
            ""bindingGroup"": ""PC"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.GetActionMap("Player");
        m_Player_Move = m_Player.GetAction("Move");
        m_Player_Shoot = m_Player.GetAction("Shoot");
        m_Player_Direction = m_Player.GetAction("Direction");
        m_Player_StartShoot = m_Player.GetAction("StartShoot");
        m_Player_EndShoot = m_Player.GetAction("EndShoot");
    }
    ~InputManager()
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
    public ReadOnlyArray<InputControlScheme> controlSchemes
    {
        get => asset.controlSchemes;
    }
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
    // Player
    private InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private InputAction m_Player_Move;
    private InputAction m_Player_Shoot;
    private InputAction m_Player_Direction;
    private InputAction m_Player_StartShoot;
    private InputAction m_Player_EndShoot;
    public struct PlayerActions
    {
        private InputManager m_Wrapper;
        public PlayerActions(InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move { get { return m_Wrapper.m_Player_Move; } }
        public InputAction @Shoot { get { return m_Wrapper.m_Player_Shoot; } }
        public InputAction @Direction { get { return m_Wrapper.m_Player_Direction; } }
        public InputAction @StartShoot { get { return m_Wrapper.m_Player_StartShoot; } }
        public InputAction @EndShoot { get { return m_Wrapper.m_Player_EndShoot; } }
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                Move.cancelled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                Shoot.cancelled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                Direction.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirection;
                Direction.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirection;
                Direction.cancelled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirection;
                StartShoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartShoot;
                StartShoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartShoot;
                StartShoot.cancelled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartShoot;
                EndShoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEndShoot;
                EndShoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEndShoot;
                EndShoot.cancelled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEndShoot;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.cancelled += instance.OnMove;
                Shoot.started += instance.OnShoot;
                Shoot.performed += instance.OnShoot;
                Shoot.cancelled += instance.OnShoot;
                Direction.started += instance.OnDirection;
                Direction.performed += instance.OnDirection;
                Direction.cancelled += instance.OnDirection;
                StartShoot.started += instance.OnStartShoot;
                StartShoot.performed += instance.OnStartShoot;
                StartShoot.cancelled += instance.OnStartShoot;
                EndShoot.started += instance.OnEndShoot;
                EndShoot.performed += instance.OnEndShoot;
                EndShoot.cancelled += instance.OnEndShoot;
            }
        }
    }
    public PlayerActions @Player
    {
        get
        {
            return new PlayerActions(this);
        }
    }
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.GetControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnDirection(InputAction.CallbackContext context);
        void OnStartShoot(InputAction.CallbackContext context);
        void OnEndShoot(InputAction.CallbackContext context);
    }
}
