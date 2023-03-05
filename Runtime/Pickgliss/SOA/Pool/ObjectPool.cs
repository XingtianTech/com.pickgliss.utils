
using System.Collections.Generic;
using UnityEngine;

namespace Pickgliss.SOA.Pool
{
    public  class ObjectPool : ScriptableObject
    {
        public PoolableObject prefab;
        public int size;
        private List<PoolableObject> pool = new List<PoolableObject>();
        
        void Awake()
        {
            pool.Clear();
            for (int i = 0; i < Size; i++)
            {
                CreateObject(); // PoolableObject handles re-adding the object to the AvailableObjects
            }
        }

        private void CreateObject()
        {
            PoolableObject poolableObject = GameObject.Instantiate(Prefab,Parent.transform);
            poolableObject.Parent = this;
            poolableObject.gameObject.SetActive(false); // PoolableObject handles re-adding the object to the AvailableObjects
        }

        public PoolableObject GetObject()
        {
            if (pool.Count == 0) // auto expand pool size if out of objects
            {
                CreateObject();
            }

            PoolableObject instance = pool[0];

            pool.RemoveAt(0);

            instance.gameObject.SetActive(true);

            return instance;
        }

        public void ReturnObjectToPool(PoolableObject Object)
        {
            pool.Add(Object);
        }
    }
} 