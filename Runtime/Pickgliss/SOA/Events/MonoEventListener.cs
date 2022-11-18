using UnityEngine;
using UnityEngine.Events;

namespace Pickgliss.SOA.Events
{
    public class MonoEventListener : MonoBehaviour,IAssetEventListener
    {
        [Tooltip("Event to register with.")]
        public AssetEvent @event;
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