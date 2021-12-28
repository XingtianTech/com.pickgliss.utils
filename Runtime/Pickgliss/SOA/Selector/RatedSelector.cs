using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pickgliss.SOA.Selector
{
    public class RatedSelector<T> : GroupSelector<T> where T : class
    {
        public List<RatedItem<T>> items = new List<RatedItem<T>>();
        public override T NextOne()
        {
            var r = prng.Value();
            for (int i = 0; i < items.Count; i++)
            {
                if(r<=items[i].rate)return items[i].item;
            }
            return null;
        }
    }

    [Serializable]
    public class RatedItem<T>
    {
        [SerializeField]
        private float _rate;
        public T item;
        public float rate => _rate;
    }
}