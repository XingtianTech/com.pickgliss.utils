using UnityEngine;
using UnityEngine.Pool;

namespace Pickgliss.Pool
{
    [CreateAssetMenu(fileName = "PrefabPool",menuName = "Pool/PrefabPool")]
    public class PrefabPool : ScriptableObject
    {
        public string description;
        public GameObject prefab;
        public bool collectionCheck = false;
        public int defaultCapacity = 9999;
        public int maxSize = 99999;
        public GameObject Get() => _pool.Get();
        public void Release(GameObject obj) => _pool.Release(obj);
        private ObjectPool<GameObject> _pool;
        private void OnEnable()
        {
            if(_pool == null)
            {
                _pool = new ObjectPool<GameObject>
                (
                    createFunc :() => Instantiate(prefab),
                    actionOnGet : (obj) => obj.SetActive(true),
                    actionOnRelease : (obj) => obj.SetActive(false),
                    actionOnDestroy : (obj) => Destroy(obj),
                    defaultCapacity : defaultCapacity,
                    collectionCheck : collectionCheck,
                    maxSize : maxSize
                );
            }
            else
            {
                _pool.Clear();
            }
        }
    }
}