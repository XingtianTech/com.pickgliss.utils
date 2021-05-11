using UnityEngine;
using UnityEngine.Events;

namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = "VoidEvent",menuName = "Event/VoidEvent")]
    public class VoidEvent : EventBase
    {
        public UnityAction OnEventRaised;
        public void RaiseEvent()
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke();
        }
    }
}