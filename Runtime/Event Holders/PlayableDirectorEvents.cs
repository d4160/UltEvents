// UltEvents // Copyright 2019 Kybernetik //

using System;
using UnityEngine;
using UnityEngine.Playables;

namespace UltEvents
{
    /************************************************************************************************************************/

    /// <summary>
    /// Holds <see cref="UltEvent"/>s which are called by various <see cref="MonoBehaviour"/> 2D trigger events:
    /// <see cref="OnTriggerEnter2D"/>, <see cref="OnTriggerStay2D"/>, and <see cref="OnTriggerExit2D"/>.
    /// </summary>
    [AddComponentMenu(UltEventUtils.ComponentMenuPrefix + "PlayableDirector Events")]
    //[HelpURL(UltEventUtils.APIDocumentationURL + "/PlayableDirectorEvents")]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(PlayableDirector))]
    public class PlayableDirectorEvents : MonoBehaviour
    {
        protected PlayableDirector _director;

        /************************************************************************************************************************/

        [SerializeField]
        private DirectorEvent _DirectorPlayedEvent;

        public DirectorEvent DirectorPlayedEvent
        {
            get
            {
                if (_DirectorPlayedEvent == null)
                    _DirectorPlayedEvent = new DirectorEvent();
                return _DirectorPlayedEvent;
            }
            set => _DirectorPlayedEvent = value;
        }

        [SerializeField]
        private DirectorEvent _DirectorPausedEvent;

        public DirectorEvent DirectorPausedEvent
        {
            get
            {
                if (_DirectorPausedEvent == null)
                    _DirectorPausedEvent = new DirectorEvent();
                return _DirectorPausedEvent;
            }
            set => _DirectorPausedEvent = value;
        }

        [SerializeField]
        private DirectorEvent _DirectorStoppedEvent;

        public DirectorEvent DirectorStoppedEvent
        {
            get
            {
                if (_DirectorStoppedEvent == null)
                    _DirectorStoppedEvent = new DirectorEvent();
                return _DirectorStoppedEvent;
            }
            set => _DirectorStoppedEvent = value;
        }

        protected void Awake()
        {
            _director = GetComponent<PlayableDirector>();
        }

        protected virtual void OnEnable()
        {
            _director.played += OnPlayed;
            _director.paused += OnPaused;
            _director.stopped += OnStopped;
        }

        protected virtual void OnDisable()
        {
            _director.played -= OnPlayed;
            _director.paused -= OnPaused;
            _director.stopped -= OnStopped;
        }

        protected void OnPlayed(PlayableDirector obj)
        {
            DirectorPlayedEvent.Invoke(obj);
        }

        protected void OnStopped(PlayableDirector obj)
        {
            DirectorStoppedEvent.Invoke(obj);
        }

        protected void OnPaused(PlayableDirector obj)
        {
            DirectorPausedEvent.Invoke(obj);
        }

        /************************************************************************************************************************/
    }

    [Serializable]
    public class DirectorEvent : UltEvent<PlayableDirector>
    {
    }
}