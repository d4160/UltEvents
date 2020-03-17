using UnityEngine;

namespace UltEvents
{
    [System.Serializable]
    public class Vector2UltEvent : UltEvent<Vector2>
    {

    }

    [System.Serializable]
    public class Vector3UltEvent : UltEvent<Vector3>
    {

    }

    [System.Serializable]
    public class FloatUltEvent : UltEvent<float>
    {
        
    }

    [System.Serializable]
    public class IntUltEvent : UltEvent<int>
    {

    }

    [System.Serializable]
    public class BoolUltEvent : UltEvent<bool>
    {

    }

    [System.Serializable]
    public class StringUltEvent : UltEvent<string>
    {

    }

    [System.Serializable]
    public class CharUltEvent : UltEvent<char>
    {

    }

    [System.Serializable]
    public class IntFloatUltEvent : UltEvent<int, float>
    {
    }
}