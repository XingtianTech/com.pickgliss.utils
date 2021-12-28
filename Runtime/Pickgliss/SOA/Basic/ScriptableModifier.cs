using Pickgliss.SOA.Event;
using UnityEngine;

namespace Pickgliss.SOA.Basic
{
    public abstract class ScriptableModifier : ScriptableObject
    {
        public VoidEvent validateEvent;
        private void OnValidate()
        {
            Debug.LogFormat("ScriptableModifier OnValidate");
            Update();
            validateEvent.RaiseEvent();
            Debug.LogFormat("ScriptableModifier validateEvent.RaiseEvent");
        }
        public virtual void Update(){}

    }
}