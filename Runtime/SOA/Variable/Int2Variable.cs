
using Unity.Mathematics;
using UnityEngine;

namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = Int2Variable.Name,menuName = SOASetting.SOA_Value + Int2Variable.Name,order = 0)]
    public class Int2Variable : NumericVariable<int2>
    {
        public const string Name = "Int2";
    }
}