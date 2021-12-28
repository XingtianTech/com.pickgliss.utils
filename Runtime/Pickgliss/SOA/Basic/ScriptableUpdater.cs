using Pickgliss.SOA.Event;
using UnityEngine;

namespace Pickgliss.SOA.Basic
{
    public abstract class ScriptableUpdater : ScriptableObject
    {
        public VoidEvent validateEvent;
        public VoidEvent updateEvent = default;
        private void OnEnable()
	    {   
            updateEvent.OnEventRaised += OnValidate;
        }
        private void OnValidate()
        {
            Update();
            validateEvent.RaiseEvent();
        }

        private void OnDisable()
        {
            updateEvent.OnEventRaised -= OnValidate;
        }
        public virtual void Update(){}
    }
}