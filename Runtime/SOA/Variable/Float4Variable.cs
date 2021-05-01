using Unity.Mathematics;
using UnityEngine;

namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = Float4Variable.Name,menuName = SOASetting.SOA_Value + Float4Variable.Name,order = 0)]
    public class Float4Variable : NumericVariable<float4>
    {
        public const string Name = "Float4";
    }
}