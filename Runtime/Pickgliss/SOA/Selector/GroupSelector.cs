using System.Collections.Generic;
using Pickgliss.SOA.Random;
using Unity.Mathematics;
using UnityEngine;

namespace Pickgliss.SOA.Selector
{
    public abstract class GroupSelector<T> : ScriptableObject
    {
        public SubSeed seed;
        public abstract T NextOne();
        public List<T> Next(int count)
        {
            var result = new List<T>();
            for (int i = 0; i < count; i++)
            {
                result.Add(NextOne());
            }
            return result;
        }

        public List<T> Next(int2 range)
        {
            var count = seed.rnd3.NextInt(range.x,range.y);
            return Next(count);
        }
        
    }
}