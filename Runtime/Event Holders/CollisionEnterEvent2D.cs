// UltEvents // Copyright 2019 Kybernetik //

using UnityEngine;

namespace UltEvents
{
    /// <summary>
    /// Holds <see cref="UltEvent"/>s which are called by various <see cref="MonoBehaviour"/> 2D collision events:
    /// <see cref="OnCollisionEnter2D"/>, <see cref="OnCollisionStay2D"/>, and <see cref="OnCollisionExit2D"/>.
    /// </summary>
    [AddComponentMenu(UltEventUtils.ComponentMenuPrefix + "Collision Enter Event 2D")]
    [HelpURL(UltEventUtils.APIDocumentationURL + "/CollisionEvents2D")]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Collider2D))]
    public class CollisionEnterEvent2D : MonoBehaviour
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
    }
}