using UnityEngine;
using UnityEngine.InputSystem;
using System.Runtime.InteropServices;

namespace UnityProjectPlaygroundCH
{
    /// <summary>
    /// Implementation of testing input events.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size = 0)]
    public struct InputTest
    {
        public void NotifyMovePerformed(InputAction.CallbackContext context)
        {
            Debug.Log("Move input performed.");
        }
    }
}
