// UltEvents // Copyright 2019 Kybernetik //

using UnityEngine;

namespace UltEvents
{
    /// <summary>
    /// Holds <see cref="UltEvent"/>s which are called by various <see cref="MonoBehaviour"/> collision events:
    /// <see cref="OnCollisionExit"/>.
    /// </summary>
    [AddComponentMenu(UltEventUtils.ComponentMenuPrefix + "Collision EnterExit Events 3D")]
    [HelpURL(UltEventUtils.APIDocumentationURL + "/CollisionEnterExitEvents3D")]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Collider))]
    public class CollisionEnterExitEvents3D : MonoBehaviour
    {
        [SerializeField]
        private CollisionEvent3D _CollisionEnterEvent;

        /// <summary>Invoked by <see cref="OnCollisionEnter"/>.</summary>
        public CollisionEvent3D CollisionEnterEvent
        {
            get
            {
                if (_CollisionEnterEvent == null)
                    _CollisionEnterEvent = new CollisionEvent3D();
                return _CollisionEnterEvent;
            }
            set { _CollisionEnterEvent = value; }
        }

        /// <summary>Invokes <see cref="CollisionEnterEvent"/>.</summary>
        public virtual void OnCollisionEnter(Collision collision)
        {
            if (_CollisionEnterEvent != null)
                _CollisionEnterEvent.Invoke(collision);
        }

        [SerializeField]
        private CollisionEvent3D _CollisionExitEvent;

        /// <summary>Invoked by <see cref="OnCollisionExit"/>.</summary>
        public CollisionEvent3D CollisionExitEvent
        {
            get
            {
                if (_CollisionExitEvent == null)
                    _CollisionExitEvent = new CollisionEvent3D();
                return _CollisionExitEvent;
            }
            set { _CollisionExitEvent = value; }
        }

        /// <summary>Invokes <see cref="CollisionExitEvent"/>.</summary>
        public virtual void OnCollisionExit(Collision collision)
        {
            if (_CollisionExitEvent != null)
                _CollisionExitEvent.Invoke(collision);
        }
    }
}