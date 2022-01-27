using System.Collections.Generic;
using UnityEngine;

namespace Pickgliss.SOA.Collections
{
    public abstract class RuntimeSet<T> : Collection<T>
    {
        // public List<T> items;
        public new bool Add(T item)
        {
            var canAdd = !items.Contains(item);
            if(canAdd){ items.Add(item); }
            return canAdd;
        }
        public new bool Remove(T item)
        {
            var canRemove = items.Contains(item);
            if(canRemove){items.Remove(item);};
            return canRemove;
        }
    }
}