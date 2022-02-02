using System.Collections.Generic;
using Pickgliss.Collections;
using UnityEngine;

namespace Pickgliss.SOA.Collections
{
    public abstract class RuntimeSet<T> : Collection<T> where T :Object
    {
        // public List<T> items;
        public virtual bool Add(T item)
        {
            var canAdd = !items.Contains(item);
            if(canAdd){ items.Add(item); }
            return canAdd;
        }
        public virtual bool Remove(T item)
        {
            var canRemove = items.Contains(item);
            if(canRemove){items.Remove(item);};
            return canRemove;
        }
    }
}