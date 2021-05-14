using Pickgliss.SOA;
using UnityEngine;
namespace Pickgliss.SOA
{
    public abstract class ScriptableModifier : ScriptableObject
    {
        public VoidEvent validateEvent;
        private void OnValidate()
        {
            Update();
            validateEvent.RaiseEvent();
        }
        protected virtual void Update(){}
    }
}