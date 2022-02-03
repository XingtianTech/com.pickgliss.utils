using Pickgliss.SOA.Collections;
using UnityEngine;

namespace Pickgliss.Tools
{
    public class ThingSpawner : PrefabSpawner
    {
        public ThingRuntimeSet group;
        public override void Spawn(GameObject prefab)
        {
            var monster = Instantiate(prefab,transform);
            var com = monster.AddComponent<Thing>();
            com.thingRuntimeSet = group;
            monster.SetActive(true);
        }
    }
}