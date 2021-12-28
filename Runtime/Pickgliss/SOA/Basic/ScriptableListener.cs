using Pickgliss.SOA.Event;
using UnityEngine;

namespace Pickgliss.SOA.Basic
{
    public abstract class ScriptableListener : ScriptableObject
    {
        public VoidEvent updateEvent = default;
        private void OnEnable()
	    {   
            updateEvent.OnEventRaised += Update;
        }

        private void OnDisable()
        {
            updateEvent.OnEventRaised -= Update;
        }
        public virtual void Update(){}
    }
}