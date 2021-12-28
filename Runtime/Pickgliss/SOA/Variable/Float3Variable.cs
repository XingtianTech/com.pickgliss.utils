using Unity.Mathematics;
using UnityEngine;

namespace Pickgliss.SOA.Variable
{
    [CreateAssetMenu(fileName = Float3Variable.Name,menuName = SOASetting.SOA_Value + Float3Variable.Name,order = 0)]
    public class Float3Variable : Variable<float3>
    {
        public const string Name = "Float3";
    }
}