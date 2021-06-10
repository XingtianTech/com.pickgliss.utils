using Unity.Mathematics;
using UnityEngine;
namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = "RandomRangeInt",menuName = "Random/RandomRangeInt")]
    public class RandomRangeInt : ScriptableObject
    {
        public SubSeed seed;
        public int2 range;
        public int Next()
        {
            return seed.rnd2.NextInt(range.x,range.y);
        }
    }
}