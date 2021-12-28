using Unity.Mathematics;
using UnityEngine;

namespace Pickgliss.SOA.Variable
{
    [CreateAssetMenu(fileName = Float4Variable.Name,menuName = SOASetting.SOA_Value + Float4Variable.Name,order = 0)]
    public class Float4Variable : Variable<float4>
    {
        public const string Name = "Float4";
    }
}