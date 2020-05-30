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
        [Tooltip("If tag is not null use layer mask instead.")]
        [SerializeField] protected string _tag;
        [Tooltip("If tag is not null use layer mask instead.")]
        [SerializeField] protected LayerMask _layerMask;
        [SerializeField] protected bool _checkAttachedRigidbody;
        [SerializeField] protected TriggerEvent3D _TriggerEnterEvent;

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
            if (string.IsNullOrEmpty(_tag))
            {
                var layer = _checkAttachedRigidbody ? (collider.attachedRigidbody ? collider.attachedRigidbody.gameObject.layer : collider.gameObject.layer) : collider.gameObject.layer;                                                                                                                                                                                                                 
                var correctLayer = IsLayer(_layerMask, layer);
                if (correctLayer)
                {
                    if (_TriggerEnterEvent != null)
                        _TriggerEnterEvent.Invoke(collider);
                }
            }
            else
            {
                var go = _checkAttachedRigidbody ? (collider.attachedRigidbody ? collider.attachedRigidbody.gameObject : collider.gameObject) : collider.gameObject;

                if (go.CompareTag(_tag))
                {
                    if (_TriggerEnterEvent != null)
                        _TriggerEnterEvent.Invoke(collider);
                }
            }
        }

        public static bool IsLayer(LayerMask mask, int layer)
        {
            return (mask.value & 1 << layer) != 0;
        }

        /************************************************************************************************************************/
    }
}