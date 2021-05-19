using Pickgliss.SOA;
using UnityEngine;
namespace Pickgliss.SOA
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
        protected virtual void Update(){}

    }
}