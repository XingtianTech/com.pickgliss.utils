using System;
using System.Collections.Generic;

namespace Pickgliss.SOA
{
    public class RandomSelector<T> : GroupSelector<T> where T :class
    {
        public List<T> list = new List<T>();
        public override T NextOne()
        {
            var index = seed.rnd2.NextInt(list.Count);
            return list[index];
        }
    }
}