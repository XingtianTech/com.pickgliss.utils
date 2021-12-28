using System.Collections.Generic;
using Pickgliss.Random;
using Unity.Mathematics;
using UnityEngine;

namespace Pickgliss.SOA.Selector
{
    public abstract class GroupSelector<T> : ScriptableObject
    {
        public Prng prng;
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
            var count = prng.Range(range.x,range.y);
            return Next(count);
        }
        
    }
}