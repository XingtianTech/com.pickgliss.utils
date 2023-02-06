
using Unity.Mathematics;
using UnityEngine;

namespace Pickgliss.SOA.Variables
{
    [CreateAssetMenu(menuName = "Utils/Variable/IntRangeVariable")]
    public class IntRangeVariable : RangeVariable<int>
    {
        public override int RandomOne()
        {
            return UnityEngine.Random.Range(min,max);
        }
    }
}