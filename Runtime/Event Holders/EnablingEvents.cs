using UnityEngine;

namespace UltEvents
{
    /// <summary>
    /// Holds <see cref="UltEvent"/>s which are called by <see cref="MonoBehaviour"/> enabling events:
    /// <see cref="OnEnable"/>, <see cref="OnDisable"/>, and
    /// </summary>
    [AddComponentMenu(UltEventUtils.ComponentMenuPrefix + "Enabling Events")]
    [DisallowMultipleComponent]
    public class EnablingEvents : MonoBehaviour
    {
        /************************************************************************************************************************/

        [SerializeField]
        private UltEvent _enableEvent;

        /// <summary>Invokes <see cref="_enableEvent"/>.</summary>
        public virtual void OnEnable()
        {
            _enableEvent?.Invoke();
        }

        /************************************************************************************************************************/

        [SerializeField]
        private UltEvent _disableEvent;

        /// <summary>Invokes <see cref="_disableEvent"/>.</summary>
        public virtual void OnDisable()
        {
            _disableEvent?.Invoke();
        }

        /************************************************************************************************************************/
    }
}