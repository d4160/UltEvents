using UltEvents;
using UnityEngine;

namespace d4160.Events
{
    public class FloatEventHolder : MonoBehaviour
    {
        [SerializeField] protected FloatModifierAction[] _actions;

        public virtual void Invoke(int index, float value)
        {
            if (index >= 0 && index < _actions.Length)
            {
                switch (_actions[index].modType)
                {
                    case FloatMod.OneMinus:
                        _actions[index]._event?.Invoke(1 - value);
                        break;
                    default:
                        break;
                }
            }
        }
    }

    [System.Serializable]
    public struct FloatModifierAction
    {
        public FloatMod modType;
        public FloatUltEvent _event;
    }

    public enum FloatMod
    {
        OneMinus
    }
}