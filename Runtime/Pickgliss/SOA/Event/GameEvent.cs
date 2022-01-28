using System.Collections.Generic;
using UnityEngine;

namespace Pickgliss.SOA.Event
{
    [CreateAssetMenu(fileName = "GameEvent",menuName = "Event/GameEvent")]
    public class GameEvent : ScriptableObject
    {
        /// <summary>
        /// The list of listeners that this event will notify if it is raised.
        /// </summary>
        protected readonly List<GameEventListener> EventListeners = 
            new();

        public virtual void Raise()
        {
            for(var i = EventListeners.Count -1; i >= 0; i--)
                EventListeners[i].OnEventRaised();
        }

        public void RegisterListener(GameEventListener listener)
        {
            if (!EventListeners.Contains(listener))
                EventListeners.Add(listener);
        }

        public void UnregisterListener(GameEventListener listener)
        {
            if (EventListeners.Contains(listener))
                EventListeners.Remove(listener);
        }
    }
}