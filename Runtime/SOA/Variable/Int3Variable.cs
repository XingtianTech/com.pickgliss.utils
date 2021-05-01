
using Unity.Mathematics;
using UnityEngine;

namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = Int3Variable.Name,menuName = SOASetting.SOA_Value + Int3Variable.Name,order = 0)]
    public class Int3Variable : NumericVariable<int3>
    {
        public const string Name = "Int3";
    }
}