using UnityEngine;
using UltEvents;

public class UltExample : MonoBehaviour
{
    public IntEvent intEvent;
}

[System.Serializable]
public class IntEvent : UltEvent<int>
{ }