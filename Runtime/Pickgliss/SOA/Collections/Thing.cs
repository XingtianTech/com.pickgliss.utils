using UnityEngine;

namespace Pickgliss.SOA.Collections
{
    [AddComponentMenu( "SOA/Thing" )]
    public class Thing : MonoBehaviour
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