
using System.Collections.Generic;
using UnityEngine;

namespace Pickgliss.SOA.Pool
{
    [CreateAssetMenu(menuName = "Utils/Collection/ObjectPool")]
    public  class ObjectPool : ScriptableObject
    {
        public PoolableObject prefab;
        // public int size;
        private Stack<PoolableObject> pool = new Stack<PoolableObject>();
        
        // void Awake()
        // {
        //     pool.Clear();
        //     for (int i = 0; i < size; i++)
        //     {
        //         CreateObject(); // PoolableObject handles re-adding the object to the AvailableObjects
        //     }
        // }

        private void CreateObject()
        {
            PoolableObject poolableObject = GameObject.Instantiate(prefab);
            poolableObject.Parent = this;
            poolableObject.gameObject.SetActive(false); // PoolableObject handles re-adding the object to the AvailableObjects
        }

        public PoolableObject GetObject()
        {
            if (pool.Count == 0) // auto expand pool size if out of objects
            {
                CreateObject();
            }

            // PoolableObject instance = pool[0];

            // pool.RemoveAt(0);
            var item = pool.Pop();

            item.gameObject.SetActive(true);

            return item;
        }

        public void ReturnObjectToPool(PoolableObject Object)
        {
            pool.Push(Object);
        }
    }
} 