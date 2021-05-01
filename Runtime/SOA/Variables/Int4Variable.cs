
using Unity.Mathematics;
using UnityEngine;

namespace Pickgliss.SOA
{
    [CreateAssetMenu(fileName = Int4Variable.Name,menuName = SOASetting.SOA_Value + Int4Variable.Name,order = 0)]
    public class Int4Variable : NumericVariable<int4>
    {
        public const string Name = "Int4";
    }
}