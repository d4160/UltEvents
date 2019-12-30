// UltEvents // Copyright 2019 Kybernetik //

using UnityEngine;

namespace UltEvents
{
    /// <summary>
    /// Holds <see cref="UltEvent"/>s which are called by various <see cref="MonoBehaviour"/> collision events:
    /// <see cref="OnCollisionStay"/>
    /// </summary>
    [AddComponentMenu(UltEventUtils.ComponentMenuPrefix + "Collision Stay Event 3D")]
    [HelpURL(UltEventUtils.APIDocumentationURL + "/CollisionStayEvent3D")]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Collider))]
    public class CollisionStayEvent3D : MonoBehaviour
    {
        [SerializeField]
        private CollisionEvent3D _CollisionStayEvent;

        /// <summary>Invoked by <see cref="OnCollisionStay"/>.</summary>
        public CollisionEvent3D CollisionStayEvent
        {
            get
            {
                if (_CollisionStayEvent == null)
                    _CollisionStayEvent = new CollisionEvent3D();
                return _CollisionStayEvent;
            }
            set { _CollisionStayEvent = value; }
        }

        /// <summary>Invokes <see cref="CollisionStayEvent"/>.</summary>
        public virtual void OnCollisionStay(Collision collision)
        {
            if (_CollisionStayEvent != null)
                _CollisionStayEvent.Invoke(collision);
        }
    }
}