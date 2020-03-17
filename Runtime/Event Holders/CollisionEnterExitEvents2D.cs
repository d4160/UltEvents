// UltEvents // Copyright 2019 Kybernetik //

using UnityEngine;

namespace UltEvents
{
    /************************************************************************************************************************/

    /// <summary>
    /// Holds <see cref="UltEvent"/>s which are called by various <see cref="MonoBehaviour"/> 2D collision events:
    /// <see cref="OnCollisionEnter2D"/>, <see cref="OnCollisionStay2D"/>, and <see cref="OnCollisionExit2D"/>.
    /// </summary>
    [AddComponentMenu(UltEventUtils.ComponentMenuPrefix + "Collision EnterExit Events 2D")]
    [HelpURL(UltEventUtils.APIDocumentationURL + "/CollisionEvents2D")]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Collider2D))]
    public class CollisionEnterExitEvents2D : MonoBehaviour
    {
        /************************************************************************************************************************/

        [SerializeField]
        private CollisionEvent2D _CollisionEnterEvent;

        /// <summary>Invoked by <see cref="OnCollisionEnter2D"/>.</summary>
        public CollisionEvent2D CollisionEnterEvent
        {
            get
            {
                if (_CollisionEnterEvent == null)
                    _CollisionEnterEvent = new CollisionEvent2D();
                return _CollisionEnterEvent;
            }
            set { _CollisionEnterEvent = value; }
        }

        /// <summary>Invokes <see cref="CollisionEnterEvent"/>.</summary>
        public virtual void OnCollisionEnter2D(Collision2D collision)
        {
            if (_CollisionEnterEvent != null)
                _CollisionEnterEvent.Invoke(collision);
        }

        /************************************************************************************************************************/

        [SerializeField]
        private CollisionEvent2D _CollisionExitEvent;

        /// <summary>Invoked by <see cref="OnCollisionExit2D"/>.</summary>
        public CollisionEvent2D CollisionExitEvent
        {
            get
            {
                if (_CollisionExitEvent == null)
                    _CollisionExitEvent = new CollisionEvent2D();
                return _CollisionExitEvent;
            }
            set { _CollisionExitEvent = value; }
        }

        /// <summary>Invokes <see cref="CollisionExitEvent"/>.</summary>
        public virtual void OnCollisionExit2D(Collision2D collision)
        {
            if (_CollisionExitEvent != null)
                _CollisionExitEvent.Invoke(collision);
        }

        /************************************************************************************************************************/
    }
}