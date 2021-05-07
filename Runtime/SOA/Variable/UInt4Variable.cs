
using Unity.Mathematics;
using UnityEngine;

namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = UInt4Variable.Name,menuName = SOASetting.SOA_Value + UInt4Variable.Name,order = 0)]
    public class UInt4Variable : Variable<uint4>
    {
        public const string Name = "UInt4";
    }
}