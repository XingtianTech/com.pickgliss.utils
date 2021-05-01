using Unity.Mathematics;
using UnityEngine;

namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = Float3Variable.Name,menuName = SOASetting.SOA_Value + Float3Variable.Name,order = 0)]
    public class Float3Variable : NumericVariable<float3>
    {
        public const string Name = "Float3";
    }
}