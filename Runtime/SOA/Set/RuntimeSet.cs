using System.Collections.Generic;
using UnityEngine;
namespace Pickgliss.SOA
{
    public abstract class RuntimeSet<T> : ScriptableObject
    {
        public List<T> Items = new List<T>();
        public bool Add(T item)
        {
            var canAdd = !Items.Contains(item);
            if(canAdd){ Items.Add(item); }
            return canAdd;
        }

        public bool Remove(T item)
        {
            var canRemove = Items.Contains(item);
            if(canRemove){Items.Remove(item);};
            return canRemove;
        }
    }
}