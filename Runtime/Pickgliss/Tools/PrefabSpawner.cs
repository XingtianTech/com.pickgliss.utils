using UnityEngine;

namespace Pickgliss.Tools
{
    public class PrefabSpawner : MonoBehaviour
    {
        public virtual void Spawn(GameObject prefab)
        {
            var monster = Instantiate(prefab,transform);
            monster.SetActive(true);
        }
    }
}