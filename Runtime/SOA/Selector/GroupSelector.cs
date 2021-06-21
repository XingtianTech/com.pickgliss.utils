using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
namespace Pickgliss.SOA
{
    public class GroupSelector<T> : ScriptableObject where T : class
    {
        public SubSeed seed;
        public virtual T NextOne(){ return null;}
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