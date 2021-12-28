using UnityEngine;
using UnityEngine.Events;

namespace Pickgliss.SOA.Event
{
    //[CreateAssetMenu(fileName = "IntEvent",menuName = "Event/IntEvent")]
    public class ParamaterEvent<T> : EventBase
    {
        public UnityAction<T> OnEventRaised;
        public void RaiseEvent(T value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}