using Pickgliss.Collections;

namespace Pickgliss.SOA.Collections
{
    public class Thing : UnityEngine.MonoBehaviour
    {
        public ThingRuntimeSet thingRuntimeSet;

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