using Pickgliss.Collections;

namespace Pickgliss.SOA.Collections
{
    public class Thing : UnityEngine.MonoBehaviour
    {
        public RuntimeSet<Thing> thingRuntimeSet;

        protected virtual void OnEnable()
        {
            thingRuntimeSet.Add(this);
        }

        protected virtual void OnDisable()
        {
            thingRuntimeSet.Remove(this);
        }
    }
} 