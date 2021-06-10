using System;
using System.Collections.Generic;
using UnityEngine;
namespace Pickgliss.SOA
{
    public class SingleSelector<T> : GroupSelector<T> where T :class
    {
        public T item;
        public override T NextOne()
        {
            return item;
        }
    }
}