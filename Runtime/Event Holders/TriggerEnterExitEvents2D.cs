// UltEvents // Copyright 2019 Kybernetik //

using UnityEngine;

namespace UltEvents
{
    /************************************************************************************************************************/

    /// <summary>
    /// Holds <see cref="UltEvent"/>s which are called by various <see cref="MonoBehaviour"/> 2D trigger events:
    /// <see cref="OnTriggerEnter2D"/>, <see cref="OnTriggerStay2D"/>, and <see cref="OnTriggerExit2D"/>.
    /// </summary>
    [AddComponentMenu(UltEventUtils.ComponentMenuPrefix + "Trigger EnterExit Events 2D")]
    [HelpURL(UltEventUtils.APIDocumentationURL + "/TriggerEvents2D")]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Collider2D))]
    public class TriggerEnterExitEvents2D : MonoBehaviour
    {
        /************************************************************************************************************************/

        [SerializeField]
        private TriggerEvent2D _TriggerEnterEvent;

        /// <summary>Invoked by <see cref="OnTriggerEnter2D"/>.</summary>
        public TriggerEvent2D TriggerEnterEvent
        {
            get
            {
                if (_TriggerEnterEvent == null)
                    _TriggerEnterEvent = new TriggerEvent2D();
                return _TriggerEnterEvent;
            }
            set { _TriggerEnterEvent = value; }
        }

        /// <summary>Invokes <see cref="TriggerEnterEvent"/>.</summary>
        public virtual void OnTriggerEnter2D(Collider2D collider)
        {
            if (_TriggerEnterEvent != null)
                _TriggerEnterEvent.Invoke(collider);
        }

        /************************************************************************************************************************/

        [SerializeField]
        private TriggerEvent2D _TriggerExitEvent;

        /// <summary>Invoked by <see cref="OnTriggerExit2D"/>.</summary>
        public TriggerEvent2D TriggerExitEvent
        {
            get
            {
                if (_TriggerExitEvent == null)
                    _TriggerExitEvent = new TriggerEvent2D();
                return _TriggerExitEvent;
            }
            set { _TriggerExitEvent = value; }
        }

        /// <summary>Invokes <see cref="TriggerExitEvent"/>.</summary>
        public virtual void OnTriggerExit2D(Collider2D collider)
        {
            if (_TriggerExitEvent != null)
                _TriggerExitEvent.Invoke(collider);
        }

        /************************************************************************************************************************/
    }
}