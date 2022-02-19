using UnityEngine;

namespace Pickgliss.Tools
{
    public class PrefabSpawner : MonoBehaviour
    {
        public void Spawn(GameObject prefab)
        {
            var item = Create(prefab);
            item.SetActive(true);
        }

        protected virtual GameObject Create(GameObject prefab)
        {
            var item = Instantiate(prefab,transform);
            return item;
        }
    }
}