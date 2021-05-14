using UnityEngine;
namespace Pickgliss.VoxelLevel
{
    public class ScriptableUpdater : ScriptableObject
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
        public abstract void Update();
    }
}