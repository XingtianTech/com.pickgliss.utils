using System.Collections.Generic;
using UnityEngine;

namespace Pickgliss.SOA.Events
{
    [CreateAssetMenu(menuName = "Utils/AssetEvent")]
    public class AssetEvent : ScriptableObject
    {
        /// <summary>
        /// The list of listeners that this event will notify if it is raised.
        /// </summary>
        // protected readonly List<IAssetEventListener> EventListeners = new();
        protected readonly List<AssetEventListenerBase> EventListeners = new();
        public void RegisterListener(AssetEventListenerBase listener)
        {
            if (!EventListeners.Contains(listener))
                EventListeners.Add(listener);
        }

        public void UnregisterListener(AssetEventListenerBase listener)
        {
            if (EventListeners.Contains(listener))
                EventListeners.Remove(listener);
        }

        public virtual void Raise()
        {
            for(var i = EventListeners.Count -1; i >= 0; i--)
            {
                EventListeners[i].OnEventRaised();
            } 
        }
    }
}



