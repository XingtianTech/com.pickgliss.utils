using Pickgliss.SOA.Collections;
using UnityEngine;

namespace Pickgliss.Tools
{
    public class ThingSpawner : PrefabSpawner
    {
        public ThingRuntimeSet group;
        protected override GameObject Create(GameObject prefab)
        {
            var item = Instantiate(prefab,transform);
            var thing = item.AddComponent<Thing>();
            thing.thingRuntimeSet = group;
            return item;
        }
    }
}