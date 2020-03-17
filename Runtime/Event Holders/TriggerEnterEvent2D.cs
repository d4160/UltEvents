// UltEvents // Copyright 2019 Kybernetik //

using UnityEngine;

namespace UltEvents
{
    /************************************************************************************************************************/

    /// <summary>
    /// Holds <see cref="UltEvent"/>s which are called by various <see cref="MonoBehaviour"/> 2D trigger events:
    /// <see cref="OnTriggerEnter2D"/>, <see cref="OnTriggerStay2D"/>, and <see cref="OnTriggerExit2D"/>.
    /// </summary>
    [AddComponentMenu(UltEventUtils.ComponentMenuPrefix + "Trigger Enter Event 2D")]
    [HelpURL(UltEventUtils.APIDocumentationURL + "/TriggerEvents2D")]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Collider2D))]
    public class TriggerEnterEvent2D : MonoBehaviour
    {
        /************************************************************************************************************************/

        [SerializeField]
        protected TriggerEvent2D _TriggerEnterEvent;

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
        public virtual void OnTriggerEnter2D(Collider2D other)
        {
            TriggerEnterEvent.Invoke(other);
        }

        /************************************************************************************************************************/
    }
}