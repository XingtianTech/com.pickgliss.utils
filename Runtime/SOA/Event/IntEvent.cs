using UnityEngine;
using UnityEngine.Events;

namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = "IntEvent",menuName = "Event/IntEvent")]
    public class IntEvent : EventBase
    {
        public UnityAction<int> OnEventRaised;
        public void RaiseEvent(int value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}