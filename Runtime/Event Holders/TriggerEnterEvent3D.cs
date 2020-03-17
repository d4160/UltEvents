// UltEvents // Copyright 2019 Kybernetik //

using UnityEngine;

namespace UltEvents
{
    /************************************************************************************************************************/

    /// <summary>
    /// Holds <see cref="UltEvent"/>s which are called by various <see cref="MonoBehaviour"/> trigger events:
    /// <see cref="OnTriggerEnter"/>, <see cref="OnTriggerStay"/>, and <see cref="OnTriggerExit"/>.
    /// </summary>
    [AddComponentMenu(UltEventUtils.ComponentMenuPrefix + "Trigger Enter Event 3D")]
    [HelpURL(UltEventUtils.APIDocumentationURL + "/TriggerEvents3D")]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Collider))]
    public class TriggerEnterEvent3D : MonoBehaviour
    {
        /************************************************************************************************************************/

        [SerializeField]
        private TriggerEvent3D _TriggerEnterEvent;

        /// <summary>Invoked by <see cref="OnTriggerEnter"/>.</summary>
        public TriggerEvent3D TriggerEnterEvent
        {
            get
            {
                if (_TriggerEnterEvent == null)
                    _TriggerEnterEvent = new TriggerEvent3D();
                return _TriggerEnterEvent;
            }
            set { _TriggerEnterEvent = value; }
        }

        /// <summary>Invokes <see cref="TriggerEnterEvent"/>.</summary>
        public virtual void OnTriggerEnter(Collider collider)
        {
            if (_TriggerEnterEvent != null)
                _TriggerEnterEvent.Invoke(collider);
        }

        /************************************************************************************************************************/
    }
}