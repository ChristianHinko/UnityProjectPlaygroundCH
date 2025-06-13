using UnityEngine;
using ChristianHinkle.PackagePlayground;

namespace UnityProjectPlaygroundCH
{
    /// <summary>
    /// Component that listens to input events and notifies the <see cref="InputTest" /> implementation.
    /// </summary>
    public class InputTestComponent : MonoBehaviour
    {
        private InputSystem_Actions m_InputSystemActions;

        private InputTest m_InputTest = new();

        void Awake()
        {
            // Create asset object.
            m_InputSystemActions = new();

            // Add the implementation's callbacks to the input delegates.
            m_InputSystemActions.Player.Move.performed += m_InputTest.NotifyMovePerformed;
        }

        void OnDestroy()
        {
            Debug.Assert(m_InputSystemActions is not null);

            // Destroy asset object.
            m_InputSystemActions.Dispose();
        }

        void OnEnable()
        {
            Debug.Assert(m_InputSystemActions is not null);

            // Enable all actions in the map.
            m_InputSystemActions.Enable();
        }

        void OnDisable()
        {
            Debug.Assert(m_InputSystemActions is not null);

            // Disable all actions in the map.
            m_InputSystemActions.Disable();
        }
    }
}
