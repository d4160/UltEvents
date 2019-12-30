// UltEvents // Copyright 2019 Kybernetik //

using UnityEngine;

namespace UltEvents
{
    /// <summary>
    /// Holds <see cref="UltEvent"/>s which are called by various <see cref="MonoBehaviour"/> collision events:
    /// <see cref="OnCollisionEnter"/>
    /// </summary>
    [AddComponentMenu(UltEventUtils.ComponentMenuPrefix + "Collision Enter Event 3D")]
    [HelpURL(UltEventUtils.APIDocumentationURL + "/CollisionEnterEvent3D")]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Collider))]
    public class CollisionEnterEvent3D : MonoBehaviour
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
    }
}