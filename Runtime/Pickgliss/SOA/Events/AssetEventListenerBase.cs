using UnityEngine;
using UnityEngine.Events;

namespace Pickgliss.SOA.Events
{
    public abstract class AssetEventListenerBase : MonoBehaviour
    {
        [Tooltip("Event to register with.")]
        public AssetEvent @event;
        // [Tooltip("Response to invoke when Event is raised.")]
        

        private void OnEnable()
        {
            @event.RegisterListener(this);
        }

        private void OnDisable()
        {
            @event.UnregisterListener(this);
        }

        public abstract void OnEventRaised();
        // {
        //     response.Invoke();
        // }
    }
}