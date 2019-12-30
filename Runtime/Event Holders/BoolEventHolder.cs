namespace UltEvents
{
    using UnityEngine;

    /// <summary>
    /// An event that takes a single <see cref="bool"/> parameter.
    /// </summary>
    [System.Serializable]
    public sealed class BoolEvent : UltEvent<bool> { }

    [AddComponentMenu(UltEventUtils.ComponentMenuPrefix + "Bool Event")]
    [DisallowMultipleComponent]
    public class BoolEventHolder : MonoBehaviour
    {
        [SerializeField]
        private BoolEvent _boolEvent;

        /// <summary>Invoked by Invoke method here.</summary>
        public BoolEvent BoolEvent
        {
            get
            {
                if (_boolEvent == null)
                    _boolEvent = new BoolEvent();
                return _boolEvent;
            }
            set { _boolEvent = value; }
        }

        public virtual void Invoke(bool value)
        {
            if (_boolEvent != null)
                _boolEvent.Invoke(value);
        }
    }
}