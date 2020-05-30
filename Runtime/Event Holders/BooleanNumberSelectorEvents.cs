using UltEvents;
using UnityEngine;

namespace d4160.Events
{
    public class BooleanNumberSelectorEvents : MonoBehaviour
    {
        [SerializeField] protected float _value;
        [SerializeField] protected UltEvent _ifIs;
        [SerializeField] protected UltEvent _ifNot;

        public void Invoke(int value)
        {
            if (_value == value)
            {
                _ifIs?.Invoke();
            }
            else
            {
                _ifNot?.Invoke();
            }
        }

        public void Invoke(float value)
        {
            if (_value == value)
            {
                _ifIs?.Invoke();
            }
            else
            {
                _ifNot?.Invoke();
            }
        }
    }
}