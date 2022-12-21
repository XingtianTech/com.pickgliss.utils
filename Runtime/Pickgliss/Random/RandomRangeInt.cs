using Unity.Mathematics;
using UnityEngine;

namespace Pickgliss.Random
{
    [CreateAssetMenu(fileName = "RandomRangeInt",menuName = "Utils/Random/RandomRangeInt")]
    public class RandomRangeInt : ScriptableObject
    {
        public Prng prng;
        public int2 range;
        public int Next()
        {
            return prng.Range(range.x,range.y);
        }
    }
}