// UltEvents // Copyright 2019 Kybernetik //

using UnityEngine;

namespace UltEvents
{
    /// <summary>
    /// Holds <see cref="UltEvent"/>s which are called by various <see cref="MonoBehaviour"/> collision events:
    /// <see cref="OnCollisionExit"/>.
    /// </summary>
    [AddComponentMenu(UltEventUtils.ComponentMenuPrefix + "Collision Exit Event 3D")]
    [HelpURL(UltEventUtils.APIDocumentationURL + "/CollisionExitEvent3D")]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Collider))]
    public class CollisionExitEvent3D : MonoBehaviour
    {
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