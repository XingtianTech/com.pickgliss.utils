using UnityEngine;
using UnityEngine.Events;

namespace Pickgliss.SOA.Event
{
    [CreateAssetMenu(fileName = "VoidEvent",menuName = "Event/VoidEvent")]
    public class VoidEvent : EventBase
    {
        public UnityAction OnEventRaised;
        public void RaiseEvent()
        {
            OnEventRaised.Invoke();
        }
    }
}