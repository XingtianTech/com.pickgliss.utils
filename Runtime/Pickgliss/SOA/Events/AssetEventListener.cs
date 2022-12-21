using UnityEngine;
using UnityEngine.Events;

namespace Pickgliss.SOA.Events
{
    public abstract class AssetEventListener : AssetEventListenerBase
    {
        public UnityEvent response;
        public override void OnEventRaised()
        {
            response.Invoke();
        }
    }
}