using UnityEngine;
using UnityEngine.Events;

namespace Pickgliss.SOA.Event
{
    public class GameEventListener : UnityEngine.MonoBehaviour
    {
        [Tooltip("Event to register with.")]
        public GameEvent @event;
        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent response;

        private void OnEnable()
        {
            @event.RegisterListener(this);
        }

        private void OnDisable()
        {
            @event.UnregisterListener(this);
        }

        public virtual void OnEventRaised()
        {
            response.Invoke();
        }
    }
}