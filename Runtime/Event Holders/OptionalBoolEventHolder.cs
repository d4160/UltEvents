namespace UltEvents
{
    using UnityEngine;

    [AddComponentMenu(UltEventUtils.ComponentMenuPrefix + "Optional Bool Event")]
    [DisallowMultipleComponent]
    public class OptionalBoolEventHolder : MonoBehaviour
    {
        [SerializeField]
        private UltEvent _onTrueEvent;

        /// <summary>The encapsulated event.</summary>
        public UltEvent OnTrueEvent
        {
            get
            {
                if (_onTrueEvent == null)
                    _onTrueEvent = new UltEvent();
                return _onTrueEvent;
            }
            set { _onTrueEvent = value; }
        }

        [SerializeField]
        private UltEvent _onFalseEvent;

        /// <summary>The encapsulated event.</summary>
        public UltEvent OnFalseEvent
        {
            get
            {
                if (_onFalseEvent == null)
                    _onFalseEvent = new UltEvent();
                return _onFalseEvent;
            }
            set { _onFalseEvent = value; }
        }


        public virtual void Invoke(bool value)
        {
            if(value)
            {
                OnTrueEvent?.Invoke();
            }
            else
            {
                OnFalseEvent?.Invoke();
            }
        }
    }
}