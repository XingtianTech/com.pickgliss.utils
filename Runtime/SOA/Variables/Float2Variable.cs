using Unity.Mathematics;
using UnityEngine;

namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = Float2Variable.Name,menuName = SOASetting.SOA_Value + Float2Variable.Name,order = 0)]
    public class Float2Variable : NumericVariable<float2>
    {
        public const string Name = "Float2";
    }
}