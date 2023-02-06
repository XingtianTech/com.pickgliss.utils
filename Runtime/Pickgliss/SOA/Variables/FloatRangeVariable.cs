
using Unity.Mathematics;
using UnityEngine;

namespace Pickgliss.SOA.Variables
{
    [CreateAssetMenu(menuName = "Utils/Variable/FloatRangeVariable")]
    public class FloatRangeVariable : RangeVariable<float>
    {
        public override float RandomOne()
        {
            return UnityEngine.Random.Range(min,max);
        }
    }
}