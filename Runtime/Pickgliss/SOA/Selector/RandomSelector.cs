using System.Collections.Generic;

namespace Pickgliss.SOA.Selector
{
    public class RandomSelector<T> : GroupSelector<T> where T :class
    {
        public List<T> list = new List<T>();
        public override T NextOne()
        {
            var index = prng.Range(0,list.Count);
            return list[index];
        }
    }
}