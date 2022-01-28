using System.Collections.Generic;
using UnityEngine;

namespace Pickgliss.SOA.Collections
{
    public  class Collection<T> : ScriptableObject where T :Object
    {
        public List<T> items;
        
        private T GetRandomOne()
        {
            var index = UnityEngine.Random.Range(0, items.Count - 1);
            return items[index];
        }

        public T GetRandomOne(T exclude = null)
        {
            while (true)
            {
                var nextOne = GetRandomOne();
                if(nextOne == exclude) continue;
                return nextOne;
            }
        }
    }
}