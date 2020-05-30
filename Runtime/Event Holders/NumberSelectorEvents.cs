using UltEvents;
using UnityEngine;

namespace d4160.Events
{
    public class NumberSelectorEvents : MonoBehaviour
    {
        [SerializeField] protected IntAction[] _actions;

        public void Invoke(int value)
        {
            for (int i = 0; i < _actions.Length; i++)
            {
                if (_actions[i].value == value)
                {
                    _actions[i]._event?.Invoke();
                }
            }
        }

        public void Invoke(float value)
        {
            for (int i = 0; i < _actions.Length; i++)
            {
                if (_actions[i].value == value)
                {
                    _actions[i]._event?.Invoke();
                }
            }
        }
    }

    [System.Serializable]
    public struct IntAction
    {
        public float value;
        public UltEvent _event;
    }
}