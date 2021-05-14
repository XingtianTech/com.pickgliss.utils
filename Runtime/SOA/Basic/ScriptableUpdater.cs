using Pickgliss.SOA;
using UnityEngine;
namespace Pickgliss.SOA
{
    public abstract class ScriptableUpdater : ScriptableObject
    {
        public VoidEvent validateEvent;
        public VoidEvent updateEvent = default;
        private void OnEnable()
	    {   
            updateEvent.OnEventRaised += Update;
        }
        private void OnValidate()
        {
            Update();
            validateEvent.RaiseEvent();
        }

        private void OnDisable()
        {
            updateEvent.OnEventRaised -= Update;
        }
        public virtual void Update(){}
    }
}